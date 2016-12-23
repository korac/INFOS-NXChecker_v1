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
                OIB         = HelperMethods.GetSubKey(RegistryNames.partnersOIB, false);
                location    = HelperMethods.GetSubKey(RegistryNames.partnersLocation, false);
                device      = HelperMethods.GetSubKey(RegistryNames.partnersDevice, false);

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
            try
            {
                HelperMethods   .SetSubKey(RegistryNames.partnersOIB, tboxOIB.Text, false);
                HelperMethods   .SetSubKey(RegistryNames.partnersLocation, tboxLocation.Text, false);
                HelperMethods   .SetSubKey(RegistryNames.partnersDevice, tboxDevice.Text, false);

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

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
