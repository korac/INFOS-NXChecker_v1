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
using Newtonsoft.Json;

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
        Timer tmr           = new Timer();
        Timer safetyTimer   = new Timer();
        const int SAFETY_PERIOD = 20 * 60 * 1000;
        //DbAgent agent;
        int safetyFlag = 0;
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
            DoWork();
        }

        private void Safety()
        {
            tmr.Start();
            File.WriteAllText(@"C:\Users\Kristijan\Desktop\SAFETY-" + DateTime.Now.ToString("dd_MM_yyyy__HH_mm_ss") + ".txt", "Error kod safety");

            safetyTimer.Interval = SAFETY_PERIOD;
            safetyTimer.Elapsed += SafetyTimerElapsed;
            safetyTimer.Start();
        }

        private void SafetyTimerElapsed(object sender, ElapsedEventArgs e)
        {
            safetyFlag++;

            if (safetyFlag < 4)
            {
                if (!DoWork())
                {
                    safetyTimer.Start();
                    return;
                }
                else
                {
                    safetyFlag = 0;
                }
            }
            else
            {
                //Final loggiraj u 'Logs' na lokalnom racunalu
                //Ili posalji email
            }            
        }     

        private bool DoWork()
        {
            try
            {
                //Check logged user
                if (!CheckUser())
                {
                    Safety();
                    return false;
                }

                //Check user's location
                if (!CheckLocation())
                {
                    Safety();
                    return false;
                }

                //Check location's device
                if (!CheckDevice())
                {
                    Safety();
                    return false;
                }

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

                tmr.Start();
                return true;
            }
            catch (Exception ex)
            {
                File.WriteAllText(@"C:\Users\Kristijan\Desktop\greska_log-" + DateTime.Now.ToString("dd_MM_yyyy__HH_mm_ss") + ".txt", "Dogodila se GRESKA: " + ex.Message + ";" + ex.TargetSite + "; " + ex.StackTrace);
                return false;
            }
        }

        private bool CheckUser()
        {
            try
            {
                string userJson = RestHelpers.GetDataSync("/check_user/" + OIB);
                if (String.IsNullOrEmpty(userJson))
                {
                    return false;
                }

                dynamic isUser = JsonConvert.DeserializeObject(userJson);

                if (isUser["COUNT(*)"] == 0)
                {
                    string isPosted = RestHelpers.PostDataSync("/insert_user", JsonConvert.SerializeObject(new { OIB = OIB, PartnerName = partnerName }));

                    if (String.IsNullOrEmpty(isPosted))
                    {
                        return false;
                    }
                }
                else if (isUser["COUNT(*)"] == 1)
                {
                    return true;
                }

                //Provjeri jos sta ako imamo COUNT > 1;
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private bool CheckLocation()
        {
            try
            {
                string locationJson = RestHelpers.GetDataSync("/check_location/" + OIB.ToString() + "," + location.ToString());

                if (String.IsNullOrEmpty(locationJson))
                {
                    return false;
                }

                dynamic isLocation = JsonConvert.DeserializeObject(locationJson);

                if (isLocation["COUNT(*)"] == 0)
                {
                    string isLocId = RestHelpers.PostDataSync("/insert_location", JsonConvert.SerializeObject(new { LocationName = location, PartnerOIB = OIB }));
                    if (String.IsNullOrEmpty(isLocId))
                    {
                        return false;
                    }

                    dynamic isLocationId = JsonConvert.DeserializeObject(isLocId);
                    Int32.TryParse(isLocationId, out locationID);
                }
                else if (isLocation["COUNT(*)"] == 1)
                {
                    string isLocId = RestHelpers.GetDataSync("/select_location/" + OIB.ToString() + "," + location.ToString());
                    if (String.IsNullOrEmpty(isLocId))
                    {
                        return false;
                    }

                    dynamic isLocationId    = JsonConvert.DeserializeObject(isLocId);
                    locationID              = isLocationId["ID"];
                }

                //Provjeri jos sta ako imamo COUNT > 1;
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private bool CheckDevice()
        {
            try
            {
                string deviceJson = RestHelpers.GetDataSync("/check_device/" + locationID.ToString() + "," + device.ToString());
                if (String.IsNullOrEmpty(deviceJson))
                {
                    return false;
                }

                dynamic isDevice = JsonConvert.DeserializeObject(deviceJson);

                if (isDevice["COUNT(*)"] == 0)
                {
                    string isDevId = RestHelpers.PostDataSync("/insert_device", JsonConvert.SerializeObject(new { DeviceName = device, LocationID = locationID }));
                    if (String.IsNullOrEmpty(isDevId))
                    {
                        return false;
                    }

                    dynamic isDeviceId = JsonConvert.DeserializeObject(isDevId);
                    Int32.TryParse(isDeviceId, out deviceID);
                }
                else if (isDevice["COUNT(*)"] == 1)
                {
                    string isDevId = RestHelpers.GetDataSync("/select_device/" + locationID.ToString() + "," + device.ToString());
                    if (String.IsNullOrEmpty(isDevId))
                    {
                        return false;
                    }

                    dynamic isDeviceId  = JsonConvert.DeserializeObject(isDevId);
                    deviceID            = isDeviceId["ID"];
                }

                //Provjeri jos sta ako imamo COUNT > 1;
                return true;
            }
            catch
            {
                return false;
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

                    if (zipFiles.Length > 0)
                    {
                        FileInfo latestZip      = zipFiles[0];

                        if (ZipFile.IsZipFile(backupPath + "\\" + latestZip.Name))
                        {
                            BackupCheck     = "OK";
                            BackupCheckDate = DateTime.Now;
                            RestHelpers.PostDataSync("/insert_log", JsonConvert.SerializeObject(new { Type = "Zip status", Message = "ZIP File " + latestZip.Name + "- VALID", DevicesID = deviceID, LogDate = DateTime.Now}));
                        }
                        else
                        {
                            BackupCheck     = "NE";
                            BackupCheckDate = DateTime.Now;
                            RestHelpers.PostDataSync("/insert_log", JsonConvert.SerializeObject(new { Type = "Zip status", Message = "ZIP File " + latestZip.Name + "- CORRUPTED", DevicesID = deviceID, LogDate = DateTime.Now }));
                        }
                    }
                }
                catch (Exception ex)
                {
                    RestHelpers.PostDataSync("/insert_log", JsonConvert.SerializeObject(new { Type = "Error - Zip status", Message = "Greska pri provjeri Backup Zip datoteka", DevicesID = deviceID, LogDate = DateTime.Now }));
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
                        RestHelpers.PostDataSync("/insert_log", JsonConvert.SerializeObject(new { Type = "Error - Temp datoteke", Message = "Greska pri brisanju Temp datoteka", DevicesID = deviceID, LogDate = DateTime.Now }));
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
                RestHelpers.PostDataSync("/insert_log", JsonConvert.SerializeObject(new { Type = "Error - Brisanje starih Backupa", Message = "Greska pri brisanju starih Backup datoteka", DevicesID = deviceID, LogDate = DateTime.Now }));
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

            }
            catch (Exception ex)
            {
                RestHelpers.PostDataSync("/insert_log", JsonConvert.SerializeObject(new { Type = "Error - Provjera diska", Message = "Greska pri provjeri slobodnog prostora na Backup disku", DevicesID = deviceID, LogDate = DateTime.Now }));
                //File.WriteAllText(@"C:\Users\Kristijan\Desktop\errorFile-" + DateTime.Now.ToString("dd_MM_yyyy__HH_mm_ss") + ".txt", "Greska kod provjere slobodnog prostora na disku: " + ex.Message);
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
            }
            catch (Exception ex)
            {
                RestHelpers.PostDataSync("/insert_log", JsonConvert.SerializeObject(new { Type = "Error - SMART Status", Message = "Greska pri provjeri SMART statusa diska (ili drugih svojstava diska)", DevicesID = deviceID, LogDate = DateTime.Now }));
            }
        }

        private void SetStatus()
        {
            object statusJsonObj = new {
                SMARTStatus         = SMARTStatus,
                AvailableFreeSpace  = AvailableFreeSpace,
                HDDType             = HDDType,
                HDDModel            = HDDModel,
                DevicesID           = deviceID,
                StatusDate          = StatusDate,
                BackupCheck         = BackupCheck,
                BackupCheckDate     = BackupCheckDate,
                TempDelDate         = TempDelDate,
                BackupCleanupDate   = BackupCleanupDate
            };

            RestHelpers.PostDataSync("/insert_status", JsonConvert.SerializeObject(statusJsonObj));
        }

        protected override void OnStop()
        {

        }
    }
}
