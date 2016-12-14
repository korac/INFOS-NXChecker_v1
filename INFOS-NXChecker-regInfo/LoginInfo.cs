using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INFOS_NXChecker_regInfo
{
    public class LoginInfo
    {
        /// <summary>
        /// Registry key string za username
        /// </summary>
        public const String username = "2eTyUm4";

        /// <summary>
        /// Registry key string za password
        /// </summary>
        public const String password = "kvVx9T0";

        private RegistryKey loginKey;

        private void CreateOpenLoginKey()
        {
            try
            {
                loginKey = Registry.CurrentUser.CreateSubKey("SOFTWARE\\C#\\NXServisAuth");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void CloseLoginKey()
        {
            try
            {
                loginKey.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public String getKorisnickoIme()
        {
            CreateOpenLoginKey();
            string returnUsername   = (string)loginKey.GetValue(username);
            CloseLoginKey();
            return returnUsername;
        }

        public void setKorisnickoIme(string val)
        {
            CreateOpenLoginKey();
            loginKey.SetValue(username, val);
            CloseLoginKey();
        }

        public String getLozinka()
        {
            CreateOpenLoginKey();
            string returnLozinka = (string)loginKey.GetValue(password);
            CloseLoginKey();
            return returnLozinka;
        }

        public void setLozinka(string val)
        {
            CreateOpenLoginKey();
            loginKey.SetValue(password, val);
            CloseLoginKey();
        }
    }
}
