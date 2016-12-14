using Microsoft.Win32;
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
        private TimeSpan timeInterval;
        private int previousMinute = 0;
        private int previousSecond = 0;
        #endregion


        public ConfigForm()
        {
            InitializeComponent();

        }

        private void ConfigForm_Load(object sender, EventArgs e)
        {
            ServiceInfo service = new ServiceInfo();

            string period   = service.getPeriod();
            string path     = service.getPath();
            
            if (string.IsNullOrEmpty(period))
            {
                service.setPeriod("");
            }
            else
            {
                try
                {
                    timeInterval = new TimeSpan(0, 0, Convert.ToInt32(period) / 1000);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Period nije integer tipa. \n" + ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }

            if(string.IsNullOrEmpty(path))
            {
                service.setPath("");
            }

            numSati.Value       = timeInterval.Hours;
            numMinute.Value     = timeInterval.Minutes;
            numSekunde.Value    = timeInterval.Seconds;

            tboxPath.Text       = path;

            try
            {
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
                MessageBox.Show("Pojavila se greška: " + ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog    = new FolderBrowserDialog();
            if(folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                tboxPath.Text   = folderBrowserDialog.SelectedPath;
            }
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            timeInterval = new TimeSpan((int) numSati.Value, (int) numMinute.Value, (int) numSekunde.Value);

            try
            {
                ServiceInfo service     = new ServiceInfo();
                service                 .setPeriod(timeInterval.TotalMilliseconds.ToString());
                service                 .setPath(tboxPath.Text);
                MessageBox              .Show("Podaci spremljeni u registar.","Podaci", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem kod spremanja podataka u registar. " + ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void numSekunde_ValueChanged(object sender, EventArgs e)
        {
            Console.WriteLine(numSekunde.Value);
            if(numSekunde.Value == 60)
            {
                numSekunde.Value = 0;
                numMinute.Value++;
            }
        }

        private void numMinute_ValueChanged(object sender, EventArgs e)
        {
            if(numMinute.Value == 60)
            {
                numMinute.Value = 0;
                numSati.Value++;
            }
        }
    }
}
