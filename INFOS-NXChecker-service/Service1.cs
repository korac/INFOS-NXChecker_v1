using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using INFOS_NXChecker_regInfo;
using System.IO;
using Ionic.Zip;
using System.Management;
using System.Data.SqlClient;

namespace INFOS_NXChecker_service
{
    public partial class NXCheckerService : ServiceBase
    {
        #region Variables
        string serverIP;
        string databaseName;
        string serverUsername;
        string serverPassword;
        string serverPort;
        string period;
        string path;
        string deletionDays;
        string tempPath1;
        string tempPath2;
        string tempPath3;
        Timer tmr = new Timer();
        #endregion

        public NXCheckerService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            try
            {
                serverIP        = HelperMethods.GetSubKey(RegistryNames.serverIP);
                databaseName    = HelperMethods.GetSubKey(RegistryNames.databaseName);
                serverUsername  = HelperMethods.GetSubKey(RegistryNames.serverUsername);
                serverPassword  = HelperMethods.GetSubKey(RegistryNames.serverPassword);
                serverPort      = HelperMethods.GetSubKey(RegistryNames.serverPort);

                period          = HelperMethods.GetSubKey(RegistryNames.period);
                path            = HelperMethods.GetSubKey(RegistryNames.path);
                deletionDays    = HelperMethods.GetSubKey(RegistryNames.deletionDays);
                
                tempPath1   = HelperMethods.GetSubKey(RegistryNames.pathTemp1);
                tempPath2   = HelperMethods.GetSubKey(RegistryNames.pathTemp2);
                tempPath3   = HelperMethods.GetSubKey(RegistryNames.pathTemp3);

                tmr.Interval    = Convert.ToInt32(period);
                tmr.Elapsed     += Tmr_Elapsed;
                tmr.Start();
            }
            catch (Exception ex)
            {
                File.WriteAllText(@"C:\Users\Kristijan\Desktop\greska_log-" + DateTime.Now.ToString("dd_MM_yyyy__HH_mm_ss") + ".txt", "ERROR PRI ČITANJU: " + ex.Message);
            }
        }

        private void Tmr_Elapsed(object sender, ElapsedEventArgs e)
        {
            try
            {                
                //Checking the latest zip file if corrupted
                ZipFileCheck(path);

                //Checking the free space on a backup disc
                BackupSpaceCheck(path);

                //Deleting files from TEMP locations
                DeleteTempFiles(tempPath1);
                DeleteTempFiles(tempPath2);
                DeleteTempFiles(tempPath3);

                //Deleting files from a Backup older than 'deletionDays' days
                DeleteOldBackupFiles(path, Convert.ToInt16(deletionDays));

                //Checking the disk SMART status
                SmartStatusCheck();

                string text = "Sve je dobro";
                string logPath = path + @"\NXChecker_service_" + DateTime.Now.ToString("dd_MM_yyyy__HH_mm_ss") + ".nxch";
                File.WriteAllText(@logPath, text);

                tmr.Start();
            }
            catch (Exception ex)
            {
                File.WriteAllText(@"C:\Users\Kristijan\Desktop\greska_log-" + DateTime.Now.ToString("dd_MM_yyyy__HH_mm_ss") + ".txt", "Dogodila se GREŠKA: " + ex.Message + ";" + ex.TargetSite + "; " + ex.StackTrace);
            }
        }

        private void CheckUser()
        {
            SqlConnection sqlCon    = new SqlConnection();
            string connectionString = "Data Source=" + serverIP + ";Initial Catalog=" + databaseName + ";User ID=" + serverUsername + ";Password=" + serverPassword;
            string query = "SELECT * FROM Partners";

            SqlCommand cmd = new SqlCommand(query, sqlCon);
            

            //In progress....
        }

        private void ZipFileCheck(string backupPath)
        {
            if (Directory.Exists(backupPath))
            {
                DirectoryInfo backupDir = new DirectoryInfo(backupPath);
                                
                try
                {
                    FileInfo[] zipFiles     = backupDir.GetFiles("*.zip");
                    zipFiles                = zipFiles.OrderByDescending(file => file.CreationTime).ToArray();
                    FileInfo latestZip      = zipFiles[0];

                    if (ZipFile.IsZipFile(backupPath + "\\" + latestZip.Name))
                    {
                        File.WriteAllText(@"C:\Users\Kristijan\Desktop\validZIP_log-" + DateTime.Now.ToString("dd_MM_yyyy__HH_mm_ss") + ".txt", "ZIP FILE " + latestZip.Name + " JE VALID!!");
                    }
                    else
                    {
                        File.WriteAllText(@"C:\Users\Kristijan\Desktop\invalidZIP_log-" + DateTime.Now.ToString("dd_MM_yyyy__HH_mm_ss") + ".txt", "ZIP FILE " + latestZip.Name + " JE CORRUPTED!!");
                    }
                }
                catch (Exception ex)
                {
                    File.WriteAllText(@"C:\Users\Kristijan\Desktop\greska_log-" + DateTime.Now.ToString("dd_MM_yyyy__HH_mm_ss") + ".txt", "Greška kod provjere ispravnosti zadnjeg ZIP filea: " + ex.Message);
                }
            }
        }

        private void DeleteTempFiles(string tempPath)
        {
            if (Directory.Exists(tempPath))
            {
                foreach (string file in Directory.GetFiles(tempPath))
                {
                    try
                    {
                        File.Delete(file);
                    }
                    catch (Exception ex)
                    {
                        File.WriteAllText(@"C:\Users\Kristijan\Desktop\deleteFile-" + DateTime.Now.ToString("dd_MM_yyyy__HH_mm_ss") + ".txt", "Greška kod brisanja temp datoteke: " + ex.Message);
                    }
                }
            }     
        }

        private void DeleteOldBackupFiles(string backupPath, int deletionDays)
        {
            try
            {
                if (Directory.Exists(backupPath))
                {
                    FileInfo[] zipFiles = new DirectoryInfo(backupPath).GetFiles("*.zip");
                    foreach (FileInfo file in zipFiles)
                    {
                        if (DateTime.UtcNow - file.CreationTimeUtc > TimeSpan.FromDays(deletionDays))
                        {
                            File.Delete(file.FullName);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                File.WriteAllText(@"C:\Users\Kristijan\Desktop\deleteFile-" + DateTime.Now.ToString("dd_MM_yyyy__HH_mm_ss") + ".txt", "Greška kod brisanja Backup file-ova: " + ex.Message);
            }
        }

        private void BackupSpaceCheck(string backupPath)
        {
            try
            {
                string text = "";
                double freeSpace;
                double totalSize;
                double postotak;
                ManagementObjectSearcher mosDisks    = new ManagementObjectSearcher("SELECT * FROM Win32_LogicalDisk WHERE DeviceID='C:'");
                
                foreach(ManagementObject moDisk in mosDisks.Get())
                {
                    freeSpace = Convert.ToDouble(moDisk["FreeSpace"]);
                    totalSize = Convert.ToDouble(moDisk["Size"]);
                    postotak  = Math.Round((freeSpace / totalSize), 3) * 100;

                    text += "FREE SPACE: " + moDisk["FreeSpace"].ToString() + ";" + Environment.NewLine;
                    text += "TOTAL SIZE: " + moDisk["Size"].ToString() + ";" + Environment.NewLine;
                    text += "Postotak " + postotak.ToString() + "% ;" + Environment.NewLine;
                }

                File.WriteAllText(@"C:\Users\Kristijan\Desktop\diskCheck-" + DateTime.Now.ToString("dd_MM_yyyy__HH_mm_ss") + ".txt", text);

            }
            catch (Exception ex)
            {
                File.WriteAllText(@"C:\Users\Kristijan\Desktop\errorFile-" + DateTime.Now.ToString("dd_MM_yyyy__HH_mm_ss") + ".txt", "Greska kod provjere slobodnog prostora na disku: " + ex.Message);
            }
        }

        private void SmartStatusCheck()
        {
            try
            {
                //Get all disk drives
                ManagementObjectSearcher mosDisks   = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");

                string text = "";
                // Loop through each object (disk) retrieved by WMI
                foreach(ManagementObject moDisk in mosDisks.Get())
                {
                    text += "S.M.A.R.T: " + moDisk["Status"].ToString() + Environment.NewLine;
                    text += "Type: " + moDisk["MediaType"].ToString() + Environment.NewLine;
                    text += "Model: " + moDisk["Model"].ToString() + Environment.NewLine;
                    text += "------------------------------------" + Environment.NewLine;
                }

                File.WriteAllText(@"C:\Users\Kristijan\Desktop\DISK_DRIVES-" + DateTime.Now.ToString("dd_MM_yyyy__HH_mm_ss") + ".txt", text);
            }
            catch (Exception ex)
            {
                File.WriteAllText(@"C:\Users\Kristijan\Desktop\errorFile-" + DateTime.Now.ToString("dd_MM_yyyy__HH_mm_ss") + ".txt", "Greska kod SMART provjere: " + ex.Message);
            }
        }

        protected override void OnStop()
        {

        }
    }
}
