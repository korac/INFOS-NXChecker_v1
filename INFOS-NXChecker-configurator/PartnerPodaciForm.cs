using INFOS_NXChecker_regInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace INFOS_NXChecker_configurator
{
    public partial class PartnerPodaciForm : Form
    {
        #region Variables
        public string OIB;
        public string location;
        public string device;
        #endregion

        public PartnerPodaciForm()
        {
            InitializeComponent();
        }

        private void PartnerPodaciForm_Load(object sender, EventArgs e)
        {
            try
            {
                OIB         = HelperMethods.GetSubKey(RegistryNames.partnersOIB);
                location    = HelperMethods.GetSubKey(RegistryNames.partnersLocation);
                device      = HelperMethods.GetSubKey(RegistryNames.partnersDevice);

                tboxOIB.Text        = OIB;
                tboxLocation.Text   = location;
                tboxDevice.Text     = device;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška kod pristupa podacima: " + ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            if (ValidateInput(tboxOIB) && ValidateInput(tboxLocation) && ValidateInput(tboxDevice))
            {
                try
                {
                    HelperMethods   .SetSubKey(RegistryNames.partnersOIB, tboxOIB.Text);
                    HelperMethods   .SetSubKey(RegistryNames.partnersLocation, tboxLocation.Text);
                    HelperMethods   .SetSubKey(RegistryNames.partnersDevice, tboxDevice.Text);

                    OIB         = tboxOIB.Text;
                    location    = tboxLocation.Text;
                    device      = tboxDevice.Text;

                    MessageBox  .Show("Podaci ažurirani.", "Podaci", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this        .DialogResult   = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Problem kod ažuriranja podataka. " + ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Unesite sve potrebne podatke", "Podaci", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tboxOIB_Validating(object sender, CancelEventArgs e)
        {
            ValidateInput(tboxOIB);
        }

        private void tboxLocation_Validating(object sender, CancelEventArgs e)
        {
            ValidateInput(tboxLocation);
        }

        private void tboxDevice_Validating(object sender, CancelEventArgs e)
        {
            ValidateInput(tboxDevice);
        }

        private bool ValidateInput(TextBox box)
        {
            bool bStatus    = true;
            if(String.IsNullOrWhiteSpace(box.Text) || String.IsNullOrEmpty(box.Text))
            {
                errProviderInput    .SetError(box, "Unesite podatke");
                bStatus             = false;
            }
            else
            {
                errProviderInput    .SetError(box, "");
            }

            return bStatus;
        }
    }
}
