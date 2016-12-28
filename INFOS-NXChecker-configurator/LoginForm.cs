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
                korisnicko   = HelperMethods.GetSubKey(RegistryNames.username);
                lozinka      = HelperMethods.GetSubKey(RegistryNames.password);

                tboxKorisnicko.Text = korisnicko;
                tboxLozinka.Text    = lozinka;
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
    }
}
