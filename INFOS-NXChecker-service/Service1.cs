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
        string partnerName;
        string OIB;
        string location;
        int locationID;
        int deviceID;
        string device;
        string period;
        string path;
        string deletionDays;
        string tempPath1;
        string tempPath2;
        string tempPath3;
        Timer tmr = new Timer();
        DbAgent agent;
        #endregion

        #region StatusVariables
        string SMARTStatus;
        string AvailableFreeSpace;
        string HDDType;
        string HDDModel;
        int DevicesID;
        DateTime StatusDate;
        string BackupCheck;
        DateTime BackupCheckDate;
        DateTime TempDelDate;
        DateTime BackupCleanupDate;
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

                partnerName = HelperMethods.GetSubKey(RegistryNames.partnerName);
                OIB         = HelperMethods.GetSubKey(RegistryNames.partnerOIB);
                location    = HelperMethods.GetSubKey(RegistryNames.partnerLocation);
                device      = HelperMethods.GetSubKey(RegistryNames.partnerDevice);

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
                //Check logged user
                CheckUser();

                //Check user's location
                CheckLocation();

                //Check location's device
                CheckDevice();

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

                StatusDate = DateTime.Now;
                SetStatus();

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
            string connectionString = GetConnectionString();

            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Partners WHERE OIB=@OIB", sqlCon))
                {
                    try
                    {
                        sqlCon.Open();

                        cmd.Parameters.AddWithValue("@OIB", OIB);

                        if ((int)cmd.ExecuteScalar() == 0)
                        {
                            using (SqlCommand insertPartnerCmd = new SqlCommand("INSERT INTO Partners VALUES (@OIB, @partnerName)", sqlCon))
                            {
                                insertPartnerCmd.Parameters .AddWithValue("@OIB", OIB);
                                insertPartnerCmd.Parameters .AddWithValue("@partnerName", partnerName);
                                insertPartnerCmd            .ExecuteNonQuery();
                            }
                        }
                        else if ((int)cmd.ExecuteScalar() == 1)
                        {
                            File.WriteAllText(@"C:\Users\Kristijan\Desktop\user-" + DateTime.Now.ToString("dd_MM_yyyy__HH_mm_ss") + ".txt", "USER POSTOJI");
                        }
                    }
                    catch (Exception ex)
                    {
                        File.WriteAllText(@"C:\Users\Kristijan\Desktop\greska_CheckUser-" + DateTime.Now.ToString("dd_MM_yyyy__HH_mm_ss") + ".txt", "Dogodila se GREŠKA: " + ex.Message + ";" + ex.TargetSite + "; " + ex.StackTrace);
                    }
                }                    
            }               

            //In progress....
        }

        private void CheckLocation()
        {
            string connectionString = GetConnectionString();

            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Locations WHERE PartnerOIB=@OIB AND LocationName=@location", sqlCon))
                {
                    try
                    {
                        sqlCon.Open();

                        cmd.Parameters.AddWithValue("@OIB", OIB);
                        cmd.Parameters.AddWithValue("@location", location);

                        if ((int)cmd.ExecuteScalar() == 0)
                        {
                            using (SqlCommand insertLocationCmd = new SqlCommand("INSERT INTO Locations (LocationName, PartnerOIB) VALUES (@location, @OIB); SELECT SCOPE_IDENTITY();", sqlCon))
                            {
                                insertLocationCmd.Parameters.AddWithValue("@location", location);
                                insertLocationCmd.Parameters.AddWithValue("@OIB", OIB);
                                locationID = (int) insertLocationCmd.ExecuteScalar();
                            }
                        }
                        else if ((int)cmd.ExecuteScalar() == 1)
                        {
                            using (SqlCommand getLocationID = new SqlCommand("SELECT ID FROM Locations WHERE PartnerOIB=@OIB AND LocationName=@location", sqlCon))
                            {
                                getLocationID.Parameters.AddWithValue("@OIB", OIB);
                                getLocationID.Parameters.AddWithValue("@location", location);

                                locationID = (int)getLocationID.ExecuteScalar();
                            }

                            File.WriteAllText(@"C:\Users\Kristijan\Desktop\location-" + DateTime.Now.ToString("dd_MM_yyyy__HH_mm_ss") + ".txt", "LOCATION POSTOJI");
                        }
                    }
                    catch (Exception ex)
                    {
                        File.WriteAllText(@"C:\Users\Kristijan\Desktop\greska_CheckLocation-" + DateTime.Now.ToString("dd_MM_yyyy__HH_mm_ss") + ".txt", "Dogodila se GREŠKA: " + ex.Message + ";" + ex.TargetSite + "; " + ex.StackTrace);
                    }
                }
            }
        }

        private void CheckDevice()
        {
            string connectionString = GetConnectionString();

            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Devices WHERE LocationID=@locationID AND DeviceName=@device", sqlCon))
                {
                    try
                    {
                        sqlCon.Open();

                        cmd.Parameters.AddWithValue("@locationID", locationID);
                        cmd.Parameters.AddWithValue("@device", device);

                        if ((int)cmd.ExecuteScalar() == 0)
                        {
                            using (SqlCommand insertDeviceCmd = new SqlCommand("INSERT INTO Devices (DeviceName, LocationID) VALUES (@device, @locationID); SELECT SCOPE_IDENTITY();", sqlCon))
                            {
                                insertDeviceCmd.Parameters.AddWithValue("@device", device);
                                insertDeviceCmd.Parameters.AddWithValue("@locationID", locationID);
                                deviceID = (int) insertDeviceCmd.ExecuteScalar();
                            }
                        }
                        else if ((int)cmd.ExecuteScalar() == 1)
                        {
                            using (SqlCommand getDeviceID = new SqlCommand("SELECT ID FROM Devices WHERE LocationID=@locationID AND DeviceName=@device", sqlCon))
                            {
                                getDeviceID.Parameters.AddWithValue("@locationID", locationID);
                                getDeviceID.Parameters.AddWithValue("@device", device);

                                deviceID = (int) getDeviceID.ExecuteScalar();
                            }

                            File.WriteAllText(@"C:\Users\Kristijan\Desktop\device-" + DateTime.Now.ToString("dd_MM_yyyy__HH_mm_ss") + ".txt", "DEVICE POSTOJI");
                        }
                    }
                    catch (Exception ex)
                    {
                        File.WriteAllText(@"C:\Users\Kristijan\Desktop\greska_CheckDevice-" + DateTime.Now.ToString("dd_MM_yyyy__HH_mm_ss") + ".txt", "Dogodila se GREŠKA: " + ex.Message + ";" + ex.TargetSite + "; " + "************* " + Environment.NewLine + locationID.ToString());
                    }
                }                    
            }
        }

        private void ZipFileCheck(string backupPath)
        {
            if (Directory.Exists(backupPath))
            {                                
                try
                {
                    DirectoryInfo backupDir = new DirectoryInfo(backupPath);
                    FileInfo[] zipFiles     = backupDir.GetFiles("*.zip");
                    zipFiles                = zipFiles.OrderByDescending(file => file.CreationTime).ToArray();
                    FileInfo latestZip      = zipFiles[0];

                    string connectionString = GetConnectionString();

                    if (ZipFile.IsZipFile(backupPath + "\\" + latestZip.Name))
                    {
                        BackupCheck     = "OK";
                        BackupCheckDate = DateTime.Now;
                        DbAgent .InsertLogs(connectionString, "Zip status", "ZIP File " + latestZip.Name + " je VALIDAN", deviceID, DateTime.Now);
                        File    .WriteAllText(@"C:\Users\Kristijan\Desktop\validZIP_log-" + DateTime.Now.ToString("dd_MM_yyyy__HH_mm_ss") + ".txt", "ZIP FILE " + latestZip.Name + " JE VALID!!");
                    }
                    else
                    {
                        BackupCheck     = "NE";
                        BackupCheckDate = DateTime.Now;
                        DbAgent .InsertLogs(connectionString, "Zip status", "ZIP File " + latestZip.Name + " je CORRUPTED", deviceID, DateTime.Now);
                        File    .WriteAllText(@"C:\Users\Kristijan\Desktop\invalidZIP_log-" + DateTime.Now.ToString("dd_MM_yyyy__HH_mm_ss") + ".txt", "ZIP FILE " + latestZip.Name + " JE CORRUPTED!!");
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

                TempDelDate = DateTime.Now;
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

                    BackupCleanupDate = DateTime.Now;
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

                    freeSpace = Math.Round(freeSpace / (1024 * 1024 * 1024), 1);
                    totalSize = Math.Round(totalSize / (1024 * 1024 * 1024), 1);

                    text += "FREE SPACE: " + freeSpace.ToString() + " GB;" + Environment.NewLine;
                    text += "TOTAL SIZE: " + totalSize.ToString() + " GB;" + Environment.NewLine;
                    text += "Postotak " + postotak.ToString() + "% ;" + Environment.NewLine;

                    AvailableFreeSpace = freeSpace.ToString() + "/" + totalSize.ToString() + " GB (" + postotak.ToString() + "%)";
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

                    SMARTStatus = moDisk["Status"].ToString();
                    HDDType     = moDisk["MediaType"].ToString();
                    HDDModel    = moDisk["Model"].ToString();
                }

                File.WriteAllText(@"C:\Users\Kristijan\Desktop\DISK_DRIVES-" + DateTime.Now.ToString("dd_MM_yyyy__HH_mm_ss") + ".txt", text);
            }
            catch (Exception ex)
            {
                File.WriteAllText(@"C:\Users\Kristijan\Desktop\errorFile-" + DateTime.Now.ToString("dd_MM_yyyy__HH_mm_ss") + ".txt", "Greska kod SMART provjere: " + ex.Message);
            }
        }

        private string GetConnectionString()
        {
            return "Data Source=" + serverIP + ";Initial Catalog=" + databaseName + ";User ID=" + serverUsername + ";Password=" + serverPassword;
        }

        private void SetStatus()
        {
            agent               = new DbAgent();
            string conString    = GetConnectionString();

            agent.SMARTStatus           = SMARTStatus;
            agent.AvailableFreeSpace    = AvailableFreeSpace;
            agent.HDDType               = HDDType;
            agent.HDDModel              = HDDModel;
            agent.DevicesID             = deviceID;
            agent.StatusDate            = StatusDate;
            agent.BackupCheck           = BackupCheck;
            agent.BackupCheckDate       = BackupCheckDate;
            agent.TempDelDate           = TempDelDate;
            agent.BackupCleanupDate     = BackupCleanupDate;

            agent.InsertStatus(conString);
        }

        protected override void OnStop()
        {

        }
    }
}
