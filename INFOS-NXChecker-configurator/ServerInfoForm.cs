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
using System.Net.NetworkInformation;
using System.Net;

namespace INFOS_NXChecker_configurator
{
    public partial class ServerInfoForm : Form
    {
        public string serverIP;
        public string databaseName;
        public string serverUsername;
        string serverPassword;
        string serverPort;

        #region Variables - Endpoints
        string fullAddress;
        string partnerSelectEndpoint;
        string partnerInsertEndpoint;
        string locationSelectEndpoint;
        string locationInsertEndpoint;
        string locationIDEndpoint;
        string deviceSelectEndpoint;
        string deviceInsertEndpoint;
        string deviceIDEndpoint;
        string statusInsertEndpoint;
        string logsInsertEndpoint;
        #endregion

        public ServerInfoForm()
        {
            InitializeComponent();
        }

        private void ServerInfoForm_Load(object sender, EventArgs e)
        {
            try
            {
                fullAddress             = HelperMethods.GetSubKey(RegistryNames.fullAddress);

                partnerSelectEndpoint   = HelperMethods.GetSubKey(RegistryNames.partnerSelectEndpoint);
                partnerInsertEndpoint   = HelperMethods.GetSubKey(RegistryNames.partnerInsertEndpoint);

                locationSelectEndpoint  = HelperMethods.GetSubKey(RegistryNames.locationSelectEndpoint);
                locationInsertEndpoint  = HelperMethods.GetSubKey(RegistryNames.locationInsertEndpoint);
                locationIDEndpoint      = HelperMethods.GetSubKey(RegistryNames.locationIDEndpoint);

                deviceSelectEndpoint    = HelperMethods.GetSubKey(RegistryNames.deviceSelectEndpoint);
                deviceInsertEndpoint    = HelperMethods.GetSubKey(RegistryNames.deviceInsertEndpoint);
                deviceIDEndpoint        = HelperMethods.GetSubKey(RegistryNames.deviceIDEndpoint);

                statusInsertEndpoint    = HelperMethods.GetSubKey(RegistryNames.statusInsertEndpoint);
                logsInsertEndpoint      = HelperMethods.GetSubKey(RegistryNames.logsInsertEndpoint);


                tboxServerAdresa.Text   = fullAddress;

                tboxPartnerSelect.Text  = partnerSelectEndpoint;
                tboxPartnerInsert.Text  = partnerInsertEndpoint;

                tboxLokacijaSelect.Text = locationSelectEndpoint;
                tboxLokacijaInsert.Text = locationInsertEndpoint;
                tboxLokacijaID.Text     = locationIDEndpoint;

                tboxUredajSelect.Text   = deviceSelectEndpoint;
                tboxUredajInsert.Text   = deviceInsertEndpoint;
                tboxUredajID.Text       = deviceIDEndpoint;

                tboxStatusInsert.Text   = statusInsertEndpoint;
                tboxLogsInsert.Text     = logsInsertEndpoint;


                //serverIP        = HelperMethods.GetSubKey(RegistryNames.serverIP);
                //databaseName    = HelperMethods.GetSubKey(RegistryNames.databaseName);
                //serverUsername  = HelperMethods.GetSubKey(RegistryNames.serverUsername);
                //serverPassword  = HelperMethods.GetSubKey(RegistryNames.serverPassword);
                //serverPort      = HelperMethods.GetSubKey(RegistryNames.serverPort);

                //tboxServerIP.Text   = serverIP;
                //tboxImeBaze.Text    = databaseName;
                //tboxPort.Text       = serverPort;

                //tboxUsername.Text   = serverUsername;
                //tboxPassword.Text   = serverPassword; 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška kod pristupa podacima: " + ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            if (ValidateInput(tboxServerAdresa) && ValidateInput(tboxPartnerSelect) && ValidateInput(tboxPartnerInsert) && ValidateInput(tboxLokacijaSelect) && ValidateInput(tboxLokacijaInsert) && ValidateInput(tboxLokacijaID) && ValidateInput(tboxUredajSelect) && ValidateInput(tboxUredajInsert) && ValidateInput(tboxUredajID) && ValidateInput(tboxStatusInsert) && ValidateInput(tboxLogsInsert))
            {
                try
                {
                    HelperMethods   .SetSubKey(RegistryNames.fullAddress, tboxServerAdresa.Text);

                    HelperMethods   .SetSubKey(RegistryNames.partnerSelectEndpoint, tboxPartnerSelect.Text);
                    HelperMethods   .SetSubKey(RegistryNames.partnerInsertEndpoint, tboxPartnerInsert.Text);

                    HelperMethods   .SetSubKey(RegistryNames.locationSelectEndpoint, tboxLokacijaSelect.Text);
                    HelperMethods   .SetSubKey(RegistryNames.locationInsertEndpoint, tboxLokacijaInsert.Text);
                    HelperMethods   .SetSubKey(RegistryNames.locationIDEndpoint, tboxLokacijaID.Text);

                    HelperMethods   .SetSubKey(RegistryNames.deviceSelectEndpoint, tboxUredajSelect.Text);
                    HelperMethods   .SetSubKey(RegistryNames.deviceInsertEndpoint, tboxUredajInsert.Text);
                    HelperMethods   .SetSubKey(RegistryNames.deviceIDEndpoint, tboxUredajID.Text);

                    HelperMethods   .SetSubKey(RegistryNames.statusInsertEndpoint, tboxStatusInsert.Text);
                    HelperMethods   .SetSubKey(RegistryNames.logsInsertEndpoint, tboxLogsInsert.Text);

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

        private void btnTestirajKonekciju_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tboxServerAdresa.Text) && !String.IsNullOrWhiteSpace(tboxServerAdresa.Text))
            {
                Ping pingSender     = new Ping();

                try
                {
                    IPAddress address   = IPAddress.Parse(tboxServerAdresa.Text);
                    PingReply reply     = pingSender.Send(address);

                    if (reply.Status == IPStatus.Success)
                    {
                        MessageBox.Show("Konekcija uspješna", "Konekcija", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Console.WriteLine("STATUS: {0}", reply.Status.ToString());
                        Console.WriteLine("Address: {0}", reply.Address.ToString());
                        Console.WriteLine("RoundTrip time: {0}", reply.RoundtripTime);
                        Console.WriteLine("Time to live: {0}", reply.Options.Ttl);
                        Console.WriteLine("Don't fragment: {0}", reply.Options.DontFragment);
                        Console.WriteLine("Buffer size: {0}", reply.Buffer.Length);
                    }
                    else
                    {
                        MessageBox.Show("Konekcija neuspješna", "Konekcija", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Problem pri konekciji! Provjerite unesenu adresu." + ex.Message, "Konekcija", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else
            {
                MessageBox.Show("Unesite adresu!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void tboxServerAdresa_Validating(object sender, CancelEventArgs e)
        {
            ValidateInput(tboxServerAdresa);
        }

        private void tboxPartnerSelect_Validating(object sender, CancelEventArgs e)
        {
            ValidateInput(tboxPartnerSelect);
        }

        private void tboxPartnerInsert_Validating(object sender, CancelEventArgs e)
        {
            ValidateInput(tboxPartnerInsert);
        }

        private void tboxLokacijaSelect_Validating(object sender, CancelEventArgs e)
        {
            ValidateInput(tboxLokacijaSelect);
        }

        private void tboxLokacijaInsert_Validating(object sender, CancelEventArgs e)
        {
            ValidateInput(tboxLokacijaInsert);
        }

        private void tboxLokacijaID_Validating(object sender, CancelEventArgs e)
        {
            ValidateInput(tboxLokacijaID);
        }

        private void tboxStatusInsert_Validating(object sender, CancelEventArgs e)
        {
            ValidateInput(tboxStatusInsert);
        }

        private void tboxLogsInsert_Validating(object sender, CancelEventArgs e)
        {
            ValidateInput(tboxLogsInsert);
        }

        private void tboxUredajSelect_Validating(object sender, CancelEventArgs e)
        {
            ValidateInput(tboxUredajSelect);
        }

        private void tboxUredajInsert_Validating(object sender, CancelEventArgs e)
        {
            ValidateInput(tboxUredajInsert);
        }

        private void tboxUredajID_Validating(object sender, CancelEventArgs e)
        {
            ValidateInput(tboxUredajID);
        }
    }
}
