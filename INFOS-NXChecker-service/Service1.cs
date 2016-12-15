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
        private String period;
        private String path;
        private Timer tmr = new Timer();
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

                tmr.Interval    = Convert.ToInt16(period);
                tmr.Elapsed     += Tmr_Elapsed;
                tmr.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine("GREŠKA: " + ex.Message);
            }
        }

        private void Tmr_Elapsed(object sender, ElapsedEventArgs e)
        {
            try
            {
                DirectoryInfo dir   = new DirectoryInfo(path);
                FileInfo[] zipFiles = dir.GetFiles("*.zip");

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

                string logPath = path + @"\NXChecker_service_" + DateTime.Now.ToString("dd_MM_yyyy__HH_mm_ss") + ".nxch";
                File.WriteAllText(@logPath, text);

                tmr.Start();
            }
            catch (Exception ex)
            {
                File.WriteAllText(@"C:\Users\Kristijan\Desktop\greska_log-" + DateTime.Now.ToString("dd_MM_yyyy__HH_mm_ss") + ".txt", "Dogodila se GREŠKA: " + ex.Message);
            }
        }

        protected override void OnStop()
        {

        }
    }
}
