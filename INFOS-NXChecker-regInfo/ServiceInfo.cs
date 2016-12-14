using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace INFOS_NXChecker_regInfo
{
    public class ServiceInfo
    {
        /// <summary>
        /// Registry key string za Period
        /// </summary>
        public const String period = "xx27aMZ";

        /// <summary>
        /// Registry key string za Path
        /// </summary>
        public const String path = "01vEllQ";

        private RegistryKey serviceKey;

        private void CreateOpenServiceKey()
        {
            try
            {
                serviceKey = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Services\\INFOS-NXChecker");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void CloseServiceKey()
        {
            try
            {
                serviceKey.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public String getPeriod()
        {
            CreateOpenServiceKey();
            string returnPeriod = (string)serviceKey.GetValue(period);
            CloseServiceKey();
            return returnPeriod;
        }

        public void setPeriod(string val)
        {
            CreateOpenServiceKey();
            serviceKey.SetValue(period, val);
            CloseServiceKey();
        }

        public String getPath()
        {
            CreateOpenServiceKey();
            string returnPath = (string)serviceKey.GetValue(path);
            CloseServiceKey();
            return returnPath;
        }

        public void setPath(string val)
        {
            CreateOpenServiceKey();
            serviceKey.SetValue(path, val);
            CloseServiceKey();
        }
    }
}
