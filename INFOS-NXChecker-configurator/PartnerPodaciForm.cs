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
        #region Properties
        public string PartnerName { get; set; }
        public string OIB { get; set; }
        public string PartnerLocation { get; set; }
        public string PartnerDevice { get; set; }
        #endregion

        public PartnerPodaciForm()
        {
            InitializeComponent();
        }

        private void PartnerPodaciForm_Load(object sender, EventArgs e)
        {
            try
            {
                PartnerName        = HelperMethods.GetSubKey(RegistryNames.partnerName);
                OIB                = HelperMethods.GetSubKey(RegistryNames.partnerOIB);
                PartnerLocation    = HelperMethods.GetSubKey(RegistryNames.partnerLocation);
                PartnerDevice      = HelperMethods.GetSubKey(RegistryNames.partnerDevice);

                tboxPartnerName.Text    = PartnerName;
                tboxOIB.Text            = OIB;
                tboxLocation.Text       = PartnerLocation;
                tboxDevice.Text         = PartnerDevice;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška kod pristupa podacima: " + ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            if (ValidateInput(tboxPartnerName) && ValidateInput(tboxOIB) && ValidateInput(tboxLocation) && ValidateInput(tboxDevice))
            {
                try
                {
                    HelperMethods   .SetSubKey(RegistryNames.partnerName, tboxPartnerName.Text);
                    HelperMethods   .SetSubKey(RegistryNames.partnerOIB, tboxOIB.Text);
                    HelperMethods   .SetSubKey(RegistryNames.partnerLocation, tboxLocation.Text);
                    HelperMethods   .SetSubKey(RegistryNames.partnerDevice, tboxDevice.Text);

                    PartnerName     = tboxPartnerName.Text;
                    OIB             = tboxOIB.Text;
                    PartnerLocation = tboxLocation.Text;
                    PartnerDevice   = tboxDevice.Text;

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

        private void tboxPartnerName_Validating(object sender, CancelEventArgs e)
        {
            ValidateInput(tboxPartnerName);
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
