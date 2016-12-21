﻿using Microsoft.Win32;
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

namespace INFOS_NXChecker_configurator
{
    public partial class ConfigForm : Form
    {
        #region Varibles
        TimeSpan timeInterval;
        string period;
        string path;
        string deleteDays;
        string tempPath1;
        string tempPath2;
        string tempPath3;
        #endregion
        
        public ConfigForm()
        {
            InitializeComponent();
        }

        private void ConfigForm_Load(object sender, EventArgs e)
        {            
            try
            {
                period      = HelperMethods.GetSubKey(RegistryNames.period, false);
                path        = HelperMethods.GetSubKey(RegistryNames.path, false);
                deleteDays  = HelperMethods.GetSubKey(RegistryNames.deletionDays, false);

                tempPath1   = HelperMethods.GetSubKey(RegistryNames.pathTemp1, false);
                tempPath2   = HelperMethods.GetSubKey(RegistryNames.pathTemp2, false);
                tempPath3   = HelperMethods.GetSubKey(RegistryNames.pathTemp3, false);

                timeInterval    = new TimeSpan(0, 0, Convert.ToInt32(period) / 1000);
                numSati.Value   = timeInterval.Hours;
                numDani.Value   = Convert.ToInt32(deleteDays);

                tboxPath.Text   = path;
                tboxTemp1.Text  = tempPath1;
                tboxTemp2.Text  = tempPath2;
                tboxTemp3.Text  = tempPath3;

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
                    HelperMethods   .SetSubKey(RegistryNames.period, timeInterval.TotalMilliseconds.ToString(), false);
                    HelperMethods   .SetSubKey(RegistryNames.path, tboxPath.Text, false);
                    HelperMethods   .SetSubKey(RegistryNames.deletionDays, numDani.Value.ToString(), false);
                    HelperMethods   .SetSubKey(RegistryNames.pathTemp1, tboxTemp1.Text, false);
                    HelperMethods   .SetSubKey(RegistryNames.pathTemp2, tboxTemp2.Text, false);
                    HelperMethods   .SetSubKey(RegistryNames.pathTemp3, tboxTemp3.Text, false);

                    MessageBox      .Show("Podaci ažurirani.", "Podaci", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Problem kod ažuriranja podataka. " + ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Unesite sve potrebne podatke");
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
    }
}
