﻿using Microsoft.Win32;
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

namespace INFOS_NXChecker_service
{
    public partial class NXCheckerService : ServiceBase
    {
        private String period;
        private String path;
        Timer tmr = new Timer();
        public NXCheckerService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            try
            {
                ServiceInfo serviceInfo = new ServiceInfo();

                period   = serviceInfo.getPeriod();
                path     = serviceInfo.getPath();

                string logPath  = path + @"\NXChecker_service_" + DateTime.Now.ToString("dd_MM_yyy__HH_mm_ss") + ".nxch";
                string text     = "Dobro je sve! Period servisa je: " + period;

                tmr.Interval = Convert.ToInt16(period);
                tmr.Elapsed += Tmr_Elapsed;
                tmr.Start();

                System.IO.File.WriteAllText(@logPath, text);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void Tmr_Elapsed(object sender, ElapsedEventArgs e)
        {
            string logPath  = path + @"\NXChecker_service_" + DateTime.Now.ToString("dd_MM_yyy__HH_mm_ss") + ".nxch";
            string text     = "Isteklo vrijeme " + period;
            System.IO.File.WriteAllText(@logPath, text);

            tmr.Start();
        }

        protected override void OnStop()
        {
        }
    }
}