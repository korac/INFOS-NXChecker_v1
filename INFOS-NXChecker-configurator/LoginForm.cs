using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using INFOS_NXChecker_regInfo;
using System.Security.Cryptography;

namespace INFOS_NXChecker_configurator
{
    public partial class LoginForm : Form
    {
        #region Variables
        private string korisnicko;
        private string lozinka;
        #endregion

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            try
            {
                korisnicko              = HelperMethods.GetSubKey(RegistryNames.username);
                string cryptedlozinka   = HelperMethods.GetSubKey(RegistryNames.password);

                if (String.IsNullOrEmpty(korisnicko) || String.IsNullOrEmpty(cryptedlozinka))
                {
                    byte[] bytePassword         = Encoding.Unicode.GetBytes("infos");
                    string encryptedPassword    = Convert.ToBase64String(ProtectedData.Protect(bytePassword, null, DataProtectionScope.CurrentUser));

                    HelperMethods.SetSubKey(RegistryNames.username, "infos");
                    HelperMethods.SetSubKey(RegistryNames.password, encryptedPassword);

                    korisnicko              = HelperMethods.GetSubKey(RegistryNames.username);
                    cryptedlozinka          = HelperMethods.GetSubKey(RegistryNames.password);
                }

                lozinka             = Encoding.Unicode.GetString(ProtectedData.Unprotect(Convert.FromBase64String(cryptedlozinka), null, DataProtectionScope.CurrentUser));

                tboxKorisnicko.Text = korisnicko;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška kod pristupa login informacijama: " + ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);

                tboxKorisnicko.Text = "";
                tboxLozinka.Text    = "";
            }  
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void Login()
        {
            if (ValidateKorisnicko() && ValidateLozinka())
            {
                try
                {
                    if (korisnicko == tboxKorisnicko.Text && lozinka == tboxLozinka.Text)
                    {
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Netočni podaci", "Podaci", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Problem kod dobavljanja podataka. " + ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Unesite potrebne podatke.", "Podaci", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tboxKorisnicko_Validating(object sender, CancelEventArgs e)
        {
            ValidateKorisnicko();
        }

        private void tboxLozinka_Validating(object sender, CancelEventArgs e)
        {
            ValidateLozinka();
        }

        private bool ValidateKorisnicko()
        {
            bool bStatus = true;
            if(tboxKorisnicko.Text == "")
            {
                errProviderKorisnicko.SetError(tboxKorisnicko, "Unesite korisničko ime");
                bStatus = false;
            }
            else
            {
                errProviderKorisnicko.SetError(tboxKorisnicko, "");
            }

            return bStatus;
        }

        private bool ValidateLozinka()
        {
            bool bStatus = true;
            if(tboxLozinka.Text == "")
            {
                errProviderLozinka  .SetError(tboxLozinka, "Unesite lozinku");
                bStatus             = false;
            }
            else
            {
                errProviderLozinka  .SetError(tboxLozinka, "");
            }

            return bStatus;
        }

        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }
    }
}
