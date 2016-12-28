using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace INFOS_NXChecker_regInfo
{
    public class HelperMethods
    {
        #region Variables
        private static RegistryKey serviceKey;
        private const String confLocation   = "SYSTEM\\CurrentControlSet\\Services\\INFOS-NXChecker";
        #endregion

        /// <summary>
        /// Gets a value for a given subkey;
        /// If subkey doesn't exists, it's created and inserted empty string;
        /// isAuth indicates whether authentication is taking place
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string GetSubKey(string key)
        {
            string location;
            location    = confLocation;
            serviceKey  = Registry.LocalMachine;

            try
            {
                serviceKey          = serviceKey.CreateSubKey(location);
                string returnVal    = (string) serviceKey.GetValue(key);

                if (string.IsNullOrEmpty(returnVal))
                {
                    SetSubKey(key, "");
                    return "";
                }

                return returnVal;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }

        /// <summary>
        /// Sets a value in registry for a given key;
        /// isAuth indicates whether authentication is taking place
        /// </summary>
        /// <param name="key"></param>
        /// <param name="val"></param>
        public static void SetSubKey(string key, string val)
        {
            string location;
            location    = confLocation;
            serviceKey  = Registry.LocalMachine;

            try
            {
                serviceKey  = serviceKey.CreateSubKey(location);
                serviceKey  .SetValue(key, val);
            }
            catch
            {
                Console.WriteLine("Greška kod spremanja podataka.");
            }
        }
    }
}
