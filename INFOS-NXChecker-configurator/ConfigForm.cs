using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Windows.Forms;
using INFOS_NXChecker_regInfo;
using System.Diagnostics;
using System.IO;

namespace INFOS_NXChecker_configurator
{
    public partial class ConfigForm : Form
    {
        #region Varibles
        TimeSpan timeInterval;
        string fullAddress;
        string partnerName;
        string OIB;
        string location;
        string device;
        string period;
        string backupPath;
        string deleteDays;
        string tempPath1;
        string tempPath2;
        string tempPath3;
        string logsFolderName;
        bool isServerInfo = true;
        bool isPartnerPod = true;
        #endregion
        
        public ConfigForm()
        {
            InitializeComponent();
        }

        private void ConfigForm_Load(object sender, EventArgs e)
        {            
            try
            {
                period      = HelperMethods.GetSubKey(RegistryNames.period);
                backupPath  = HelperMethods.GetSubKey(RegistryNames.path);
                deleteDays  = HelperMethods.GetSubKey(RegistryNames.deletionDays);

                fullAddress = HelperMethods.GetSubKey(RegistryNames.fullAddress);

                partnerName = HelperMethods.GetSubKey(RegistryNames.partnerName);
                OIB         = HelperMethods.GetSubKey(RegistryNames.partnerOIB);
                location    = HelperMethods.GetSubKey(RegistryNames.partnerLocation);
                device      = HelperMethods.GetSubKey(RegistryNames.partnerDevice);

                tempPath1   = HelperMethods.GetSubKey(RegistryNames.pathTemp1);
                tempPath2   = HelperMethods.GetSubKey(RegistryNames.pathTemp2);
                tempPath3   = HelperMethods.GetSubKey(RegistryNames.pathTemp3);

                logsFolderName    = HelperMethods.GetSubKey(RegistryNames.logsName);

                if (!String.IsNullOrEmpty(logsFolderName))
                {
                    lblFolderName.Text  = "..\\" + logsFolderName;
                }

                lblFullAddressInfo.Text = fullAddress;

                if (!String.IsNullOrEmpty(period))
                {
                    timeInterval    = new TimeSpan(0, 0, Convert.ToInt32(period) / 1000);
                    numSati.Value   = timeInterval.Hours;
                    numDani.Value   = Convert.ToInt32(deleteDays);
                }

                tboxPath.Text   = backupPath;
                tboxTemp1.Text  = tempPath1;
                tboxTemp2.Text  = tempPath2;
                tboxTemp3.Text  = tempPath3;

                CheckInfoPodaci(lblFullAddressInfo, fullAddress, "punu adresu", false);

                CheckInfoPodaci(lblPartnerName, partnerName, "ime partnera", true);
                CheckInfoPodaci(lblLocation, location, "lokaciju", true);
                CheckInfoPodaci(lblDevice, device, "uređaj", true);

                EnableConfiguration();

                ServiceController nxService = new ServiceController("NXCheckerService");
                if(nxService.Status.ToString() == "Running")
                {
                    lblServiceStatus.Text       = "RUNNING";                    
                    lblServiceStatus.ForeColor  = Color.Chartreuse;

                    btnRunStop.Text             = "Zaustavi Servis".ToUpper();
                    btnRunStop.ForeColor        = Color.IndianRed;
                }
                else if (nxService.Status.ToString() == "Stopped")
                {
                    lblServiceStatus.Text       = "STOPPED";
                    lblServiceStatus.ForeColor  = Color.LightSalmon;

                    btnRunStop.Text             = "Pokreni servis".ToUpper();
                    btnRunStop.ForeColor        = Color.Chartreuse;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPath_Click(object sender, EventArgs e)
        {
            FolderBrowser(tboxPath);
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            if(ValidatePath(tboxPath) && ValidatePath(tboxTemp1) && ValidatePath(tboxTemp2) && ValidatePath(tboxTemp3))
            {
                timeInterval = new TimeSpan((int)numSati.Value, 0, 0);
                try
                {
                    HelperMethods   .SetSubKey(RegistryNames.period, timeInterval.TotalMilliseconds.ToString());
                    HelperMethods   .SetSubKey(RegistryNames.path, tboxPath.Text);
                    HelperMethods   .SetSubKey(RegistryNames.deletionDays, numDani.Value.ToString());
                    HelperMethods   .SetSubKey(RegistryNames.pathTemp1, tboxTemp1.Text);
                    HelperMethods   .SetSubKey(RegistryNames.pathTemp2, tboxTemp2.Text);
                    HelperMethods   .SetSubKey(RegistryNames.pathTemp3, tboxTemp3.Text);

                    MessageBox      .Show("Podaci ažurirani.", "Podaci", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnRunStop_Click(object sender, EventArgs e)
        {
            try
            {
                ServiceController nxService = new ServiceController("NXCheckerService");
                if(nxService.Status.ToString() == "Stopped")
                {
                    nxService.Start();
                    lblServiceStatus.Text       = "RUNNING";                    
                    lblServiceStatus.ForeColor  = Color.Chartreuse;

                    btnRunStop.Text             = "Zaustavi Servis".ToUpper();
                    btnRunStop.ForeColor        = Color.IndianRed;
                }
                else
                {
                    nxService.Stop();
                    lblServiceStatus.Text       = "STOPPED";                    
                    lblServiceStatus.ForeColor  = Color.LightSalmon;

                    btnRunStop.Text             = "Pokreni Servis".ToUpper();
                    btnRunStop.ForeColor        = Color.Chartreuse;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem sa servisom: " + ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTemp1_Click(object sender, EventArgs e)
        {
            FolderBrowser(tboxTemp1);
        }

        private void btnTemp2_Click(object sender, EventArgs e)
        {
            FolderBrowser(tboxTemp2);
        }

        private void btnTemp3_Click(object sender, EventArgs e)
        {
            FolderBrowser(tboxTemp3);
        }

        private void FolderBrowser(TextBox tbox)
        {
            try
            {
                FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    tbox.Text = folderBrowserDialog.SelectedPath;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOpenLogs_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(logsFolderName))
            {
                try
                {
                    Process.Start(Path.GetTempPath() + logsFolderName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Unesite naziv direktorija", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnChangeLogs_Click(object sender, EventArgs e)
        {
            LogsPathForm logsForm = new LogsPathForm();
            if (logsForm.ShowDialog() == DialogResult.OK)
            {
                logsFolderName          = logsForm.FolderName;
                lblFolderName.Text      = "..\\" + logsForm.FolderName; 
            }
        }

        private void tboxPath_Validating(object sender, CancelEventArgs e)
        {
            ValidatePath(tboxPath);
        }

        private void tboxTemp1_Validating(object sender, CancelEventArgs e)
        {
            ValidatePath(tboxTemp1);
        }

        private void tboxTemp2_Validating(object sender, CancelEventArgs e)
        {
            ValidatePath(tboxTemp2);
        }

        private void tboxTemp3_Validating(object sender, CancelEventArgs e)
        {
            ValidatePath(tboxTemp3);
        }

        private bool ValidatePath(TextBox box)
        {
            bool bStatus    = true;
            if(String.IsNullOrWhiteSpace(box.Text) || String.IsNullOrEmpty(box.Text))
            {
                errProviderBackup   .SetError(box, "Unesite lokaciju za direktorij");
                bStatus             = false;
            }
            else
            {
                errProviderBackup   .SetError(box, "");
            }

            return bStatus;
        }

        private void btnServerInfo_Click(object sender, EventArgs e)
        {
            ServerInfoForm infoForm   = new ServerInfoForm();
            if(infoForm.ShowDialog() == DialogResult.OK)
            {
                lblFullAddressInfo.Text        = infoForm.FullAddress;
                lblFullAddressInfo.ForeColor   = Color.DimGray;

                isServerInfo = true;
                EnableConfiguration();
            }
        }

        private void btnPartnerPodaci_Click(object sender, EventArgs e)
        {
            PartnerPodaciForm partnerForm   = new PartnerPodaciForm();
            if(partnerForm.ShowDialog() == DialogResult.OK)
            {
                lblPartnerName.Text = partnerForm.PartnerName;
                lblLocation.Text    = partnerForm.PartnerLocation;
                lblDevice.Text      = partnerForm.PartnerDevice;

                lblPartnerName.ForeColor    = Color.DimGray;
                lblLocation.ForeColor       = Color.DimGray;
                lblDevice.ForeColor         = Color.DimGray;

                isPartnerPod = true;
                EnableConfiguration();
            }
        }

        private void CheckInfoPodaci(Label lbl, string val, string valName, bool isPartners)
        {
            if (String.IsNullOrWhiteSpace(val))
            {
                lbl.Text        = "Unesite " + valName;
                lbl.ForeColor   = Color.IndianRed;
                if (isPartners)
                {
                    isPartnerPod = false;
                }
                else
                {
                    isServerInfo = false;
                }                
            }
            else
            {
                lbl.Text        = val;
                lbl.ForeColor   = Color.DimGray;
            }
        }

        private void EnableConfiguration()
        {
            if (isPartnerPod && isServerInfo)
            {
                gboxPostavke.Enabled    = true;
                gboxTemps.Enabled       = true;
                gboxLogs.Enabled        = true;
                btnSpremi.Enabled       = true;
                btnChangeLogs.Enabled   = true;
                btnOpenLogs.Enabled     = true;
            }
            else
            {
                gboxPostavke.Enabled    = false;
                gboxTemps.Enabled       = false;
                gboxLogs.Enabled        = false;
                btnSpremi.Enabled       = false;
                btnChangeLogs.Enabled   = false;
                btnOpenLogs.Enabled     = false;
            }
        }

        private void btnSpremi_EnabledChanged(object sender, EventArgs e)
        {
            if(btnSpremi.Enabled == true)
            {
                btnSpremi.ForeColor = Color.White;
                btnSpremi.BackColor = SystemColors.Highlight;
            }
            else
            {
                btnSpremi.ForeColor = Color.Silver;
                btnSpremi.BackColor = SystemColors.ButtonShadow;
            }
            
        }

        private void btnChangeLogs_EnabledChanged(object sender, EventArgs e)
        {
            if (btnChangeLogs.Enabled == true && btnOpenLogs.Enabled == true)
            {
                btnChangeLogs.ForeColor = Color.White;
                btnChangeLogs.BackColor = Color.IndianRed;

                btnOpenLogs.ForeColor = Color.White;
                btnOpenLogs.BackColor = Color.IndianRed;
            }
            else
            {
                btnChangeLogs.ForeColor = Color.Silver;
                btnChangeLogs.BackColor = SystemColors.ButtonShadow;

                btnOpenLogs.ForeColor = Color.Silver;
                btnOpenLogs.BackColor = SystemColors.ButtonShadow;
            }
        }
    }
}
