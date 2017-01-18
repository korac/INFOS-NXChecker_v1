using INFOS_NXChecker_regInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace INFOS_NXChecker_configurator
{
    public partial class LogsPathForm : Form
    {
        public string FolderName { get; set; }
        public string FullLogsPath { get; set; }

        public LogsPathForm()
        {
            InitializeComponent();
        }

        private void LogsPathForm_Load(object sender, EventArgs e)
        {
            try
            {
                FolderName  = HelperMethods.GetSubKey(RegistryNames.logsName);

                tboxFolderName.Text = FolderName;
                tboxFullPath.Text   = Path.GetTempPath() + FolderName;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška kod pristupa podacima: " + ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            if (ValidateInput(tboxFolderName))
            {
                try
                {
                    HelperMethods   .SetSubKey(RegistryNames.logsName, tboxFolderName.Text);
                    HelperMethods   .SetSubKey(RegistryNames.pathLogs, tboxFullPath.Text);

                    FolderName      = tboxFolderName.Text;
                    FullLogsPath    = tboxFullPath.Text;

                    if (Directory.Exists(FullLogsPath))
                    {
                        MessageBox  .Show("Podaci ažurirani.", "Podaci", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this        .DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        Directory       .CreateDirectory(FullLogsPath);

                        MessageBox      .Show("Novi direktorij napravljen, te podaci ažurirani.", "Podaci", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this            .DialogResult = DialogResult.OK;
                    }                    
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

        private void tboxFolderName_KeyUp(object sender, KeyEventArgs e)
        {
            tboxFullPath.Text = Path.GetTempPath() + tboxFolderName.Text;
        }

        private void tboxFolderName_Validating(object sender, CancelEventArgs e)
        {
            ValidateInput(tboxFolderName);
        }

        private bool ValidateInput(TextBox box)
        {
            bool bStatus = true;
            if (String.IsNullOrWhiteSpace(box.Text) || String.IsNullOrEmpty(box.Text))
            {
                errProviderInput.SetError(box, "Unesite potreban podatak");
                bStatus = false;
            }
            else
            {
                errProviderInput.SetError(box, "");
            }

            return bStatus;
        }
    }
}
