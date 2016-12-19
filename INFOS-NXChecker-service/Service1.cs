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

namespace INFOS_NXChecker_service
{
    public partial class NXCheckerService : ServiceBase
    {
        #region Variables
        string period;
        string path;
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
                period   = HelperMethods.GetSubKey(RegistryNames.period, false);
                path     = HelperMethods.GetSubKey(RegistryNames.path, false);
                
                tempPath1   = HelperMethods.GetSubKey(RegistryNames.pathTemp1, false);
                tempPath2   = HelperMethods.GetSubKey(RegistryNames.pathTemp2, false);
                tempPath3   = HelperMethods.GetSubKey(RegistryNames.pathTemp3, false);

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
                DirectoryInfo backupDir     = new DirectoryInfo(path);
                DirectoryInfo tempOneDir    = new DirectoryInfo(tempPath1);
                DirectoryInfo tempTwoDir    = new DirectoryInfo(tempPath2);
                DirectoryInfo tempThreeDir  = new DirectoryInfo(tempPath3);

                FileInfo[] zipFiles         = backupDir.GetFiles("*.zip");
                FileInfo[] tempOneFiles     = tempOneDir.GetFiles();
                FileInfo[] tempTwoFiles     = tempOneDir.GetFiles();
                FileInfo[] tempThreeFiles   = tempOneDir.GetFiles();

                zipFiles            = zipFiles.OrderByDescending(file => file.CreationTime).ToArray();
                FileInfo latestZip  = zipFiles[0];

                string text = "";
                text        += "LATEST ZIP FILE IS: " + latestZip.Name + "; \n";
                text        += "ZIP File status: ";

                if (ZipFile.CheckZip(path + "\\" + latestZip.Name))
                {
                    text += "VALID!";
                }
                else
                {
                    text += "INVALID!";
                }

                //foreach (FileInfo file in zipFiles)
                //{
                //    text += file.Name;
                //    text += " - ";
                //    text += file.LastWriteTime;
                //    text += "; \n";
                //}

                //Deleting files from TEMP locations
                DeleteTempFiles(tempPath1);
                DeleteTempFiles(tempPath2);
                DeleteTempFiles(tempPath3);

                DeleteOldBackupFiles(path);

                string logPath = path + @"\NXChecker_service_" + DateTime.Now.ToString("dd_MM_yyyy__HH_mm_ss") + ".nxch";
                File.WriteAllText(@logPath, text);

                tmr.Start();
            }
            catch (Exception ex)
            {
                File.WriteAllText(@"C:\Users\Kristijan\Desktop\greska_log-" + DateTime.Now.ToString("dd_MM_yyyy__HH_mm_ss") + ".txt", "Dogodila se GREŠKA: " + ex.Message);
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
                        File.WriteAllText(@"C:\Users\Kristijan\Desktop\deleteFile-" + DateTime.Now.ToString("dd_MM_yyyy__HH_mm_ss") + ".txt", "Dogodila se GREŠKA: " + ex.Message);
                    }
                }
            }     
        }

        private void DeleteOldBackupFiles(string backupPath)
        {
            try
            {
                if (Directory.Exists(backupPath))
                {
                    FileInfo[] zipFiles = new DirectoryInfo(@backupPath).GetFiles("*.zip");
                    File.WriteAllText(@"C:\Users\Kristijan\Desktop\zips-" + DateTime.Now.ToString("dd_MM_yyyy__HH_mm_ss") + ".txt", "zips su tu: " + zipFiles.ToString());
                    foreach (FileInfo file in zipFiles)
                    {
                        if (DateTime.UtcNow - file.CreationTimeUtc > TimeSpan.FromDays(3))
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

        protected override void OnStop()
        {

        }
    }
}
