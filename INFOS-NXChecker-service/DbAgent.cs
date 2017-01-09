using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;

namespace INFOS_NXChecker_service
{
    class DbAgent
    {

        #region Properties
        public string SMARTStatus { get; set; }
        public string AvailableFreeSpace { get; set; }
        public string HDDType { get; set; }
        public string HDDModel { get; set; }
        public int? DevicesID { get; set; }
        public DateTime? StatusDate { get; set; }
        public string BackupCheck { get; set; }
        public DateTime? BackupCheckDate { get; set; }
        public DateTime? TempDelDate { get; set; }
        public DateTime? BackupCleanupDate { get; set; }

        #endregion

        public DbAgent()
        {
            this.SMARTStatus        = String.Empty;
            this.AvailableFreeSpace = String.Empty;
            this.HDDType            = String.Empty;
            this.HDDModel           = String.Empty;
            this.DevicesID          = null;
            this.StatusDate         = null;
            this.BackupCheck        = String.Empty;
            this.BackupCheckDate    = null;
            this.TempDelDate        = null;
            this.BackupCleanupDate  = null;
        }

        public bool InsertStatus(string conString)
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO Status(SMARTStatus, AvailableFreeSpace, HDDType, HDDModel, DevicesID, StatusDate, BackupCheck, BackupCheckDate, TempDelDate, BackupCleanupDate) VALUES (@SMARTStatus, @AvailableFreeSpace, @HDDType, @HDDModel, @DevicesID, @StatusDate, @BackupCheck, @BackupCheckDate, @TempDelDate, @BackupCleanupDate)", sqlCon))
                    {
                        sqlCon.Open();

                        cmd.Parameters.AddWithValue("@SMARTStatus", SMARTStatus);
                        cmd.Parameters.AddWithValue("@AvailableFreeSpace", AvailableFreeSpace);
                        cmd.Parameters.AddWithValue("@HDDType", HDDType);
                        cmd.Parameters.AddWithValue("@HDDModel", HDDModel);
                        cmd.Parameters.AddWithValue("@DevicesID", DevicesID);
                        cmd.Parameters.AddWithValue("@StatusDate", StatusDate);
                        cmd.Parameters.AddWithValue("@BackupCheck", BackupCheck);
                        cmd.Parameters.AddWithValue("@BackupCheckDate", BackupCheckDate);
                        cmd.Parameters.AddWithValue("@TempDelDate", TempDelDate);
                        cmd.Parameters.AddWithValue("@BackupCleanupDate", BackupCleanupDate);

                        cmd.ExecuteScalar();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                File.WriteAllText(@"C:\Users\Kristijan\Desktop\dbAgentERROR-" + DateTime.Now.ToString("dd_MM_yyyy__HH_mm_ss") + ".txt", "Greska: " + this.SMARTStatus + "; " + this.AvailableFreeSpace + "; " + this.HDDType+ "; " + this.HDDModel+ "; " + this.DevicesID+ "; " + this.StatusDate + "; " + this.BackupCheck + "; " + this.BackupCheckDate + "; " + this.TempDelDate + "; " + this.BackupCleanupDate + "; " );
                return false;
            }
        }

        public static void InsertLogs(string conString, string type, string message, int deviceID, DateTime date)
        {
            using (SqlConnection sqlCon = new SqlConnection(conString))
            {
                using (SqlCommand cmd = new SqlCommand("INSERT INTO Logs(Type, Message, DevicesID, LogDate) VALUES (@type, @message, @devicesID, @logdate)", sqlCon))
                {
                    sqlCon.Open();

                    cmd.Parameters.AddWithValue("@type", type);
                    cmd.Parameters.AddWithValue("@message", message);
                    cmd.Parameters.AddWithValue("@devicesID", deviceID);
                    cmd.Parameters.AddWithValue("@logdate", date);

                    cmd.ExecuteScalar();
                }
            }
        }
    }
}
