using INFOS_NXChecker_regInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace INFOS_NXChecker_configurator
{
    public partial class ServerInfoForm : Form
    {
        public string serverIP;
        public string databaseName;
        public string serverUsername;
        string serverPassword;
        string serverPort;
        public ServerInfoForm()
        {
            InitializeComponent();
        }

        private void ServerInfoForm_Load(object sender, EventArgs e)
        {
            try
            {
                serverIP        = HelperMethods.GetSubKey(RegistryNames.serverIP);
                databaseName    = HelperMethods.GetSubKey(RegistryNames.databaseName);
                serverUsername  = HelperMethods.GetSubKey(RegistryNames.serverUsername);
                serverPassword  = HelperMethods.GetSubKey(RegistryNames.serverPassword);
                serverPort      = HelperMethods.GetSubKey(RegistryNames.serverPort);

                tboxServerIP.Text   = serverIP;
                tboxImeBaze.Text    = databaseName;
                tboxPort.Text       = serverPort;
                
                tboxUsername.Text   = serverUsername;
                tboxPassword.Text   = serverPassword; 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška kod pristupa podacima: " + ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            if (ValidateInput(tboxServerIP) && ValidateInput(tboxImeBaze) && ValidateInput(tboxPort) && ValidateInput(tboxUsername) && ValidateInput(tboxPassword))
            {
                try
                {
                    HelperMethods   .SetSubKey(RegistryNames.serverIP, tboxServerIP.Text);
                    HelperMethods   .SetSubKey(RegistryNames.databaseName, tboxImeBaze.Text);
                    HelperMethods   .SetSubKey(RegistryNames.serverPort, tboxPort.Text);
                    HelperMethods   .SetSubKey(RegistryNames.serverUsername, tboxUsername.Text);
                    HelperMethods   .SetSubKey(RegistryNames.serverPassword, tboxPassword.Text);

                    serverIP        = tboxServerIP.Text;
                    databaseName    = tboxImeBaze.Text;
                    serverUsername  = tboxUsername.Text;

                    MessageBox      .Show("Podaci ažurirani.", "Podaci", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this            .DialogResult = DialogResult.OK;
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

        private void tboxServerIP_Validating(object sender, CancelEventArgs e)
        {
            ValidateInput(tboxServerIP);
        }

        private void tboxImeBaze_Validating(object sender, CancelEventArgs e)
        {
            ValidateInput(tboxImeBaze);
        }

        private void tboxPort_Validating(object sender, CancelEventArgs e)
        {
            ValidateInput(tboxPort);
        }

        private void tboxUsername_Validating(object sender, CancelEventArgs e)
        {
            ValidateInput(tboxUsername);
        }

        private void tboxPassword_Validating(object sender, CancelEventArgs e)
        {
            ValidateInput(tboxPassword);
        }

        private bool ValidateInput(TextBox box)
        {
            bool bStatus    = true;
            if(String.IsNullOrWhiteSpace(box.Text) || String.IsNullOrEmpty(box.Text))
            {
                errProviderInput .SetError(box, "Unesite potreban podatak");
                bStatus          = false;
            }
            else
            {
                errProviderInput .SetError(box, "");
            }

            return bStatus;
        }

        private void cBoxLozinka_CheckedChanged(object sender, EventArgs e)
        {
            if (cBoxLozinka.Checked)
            {
                tboxPassword.PasswordChar = '\0';
            }
            else if(!cBoxLozinka.Checked)
            {
                tboxPassword.PasswordChar = Convert.ToChar("*");
            }
        }

        private void btnTestirajKonekciju_Click(object sender, EventArgs e)
        {
            serverIP        = tboxServerIP.Text;
            databaseName    = tboxImeBaze.Text;
            serverUsername  = tboxUsername.Text;
            serverPassword  = tboxPassword.Text;
            
            string connectionString = "Data Source=" + serverIP +";Initial Catalog=" + databaseName + ";User ID=" + serverUsername + ";Password=" + serverPassword;

            SqlConnection sqlCon = new SqlConnection(connectionString);

            try
            {
                this.Cursor = Cursors.WaitCursor;
                sqlCon.Open();
                this.Cursor = Cursors.Default;
                MessageBox.Show("Konekcija uspješna!", "Konekcija", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                this.Cursor = Cursors.Default;
                MessageBox.Show("Greška pri konekciji", "Konekcija", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
