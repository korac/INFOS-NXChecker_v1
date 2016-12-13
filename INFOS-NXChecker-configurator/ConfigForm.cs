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
        private TimeSpan timeInterval;
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
                    timeInterval = new TimeSpan(0, 0, Convert.ToInt16(period));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Period nije integer tipa. \n" + ex.Message);
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
                    lblServiceStatus.ForeColor  = SystemColors.Highlight;

                    btnRunStop.Text             = "Zaustavi Servis".ToUpper();
                    btnRunStop.BackColor        = Color.IndianRed;
                }
                else if (nxService.Status.ToString() == "Stopped")
                {
                    lblServiceStatus.Text       = "STOPPED";
                    lblServiceStatus.ForeColor  = Color.IndianRed;

                    btnRunStop.Text             = "Pokreni servis".ToUpper();
                    btnRunStop.BackColor        = SystemColors.Highlight;
                }

            }
            catch (Exception ex)
            {
                throw ex;
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
            Console.WriteLine(tboxPath.Text);
            Console.WriteLine(timeInterval.TotalMilliseconds);

            try
            {
                ServiceInfo service     = new ServiceInfo();
                service.setPeriod(timeInterval.TotalSeconds.ToString());
                service.setPath(tboxPath.Text);
                MessageBox              .Show("Podaci spremljeni u registar.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem kod spremanja podataka u registar. " + ex.Message);
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
                    lblServiceStatus.ForeColor  = SystemColors.Highlight;

                    btnRunStop.Text             = "Zaustavi Servis".ToUpper();
                    btnRunStop.BackColor        = Color.IndianRed;
                }
                else
                {
                    nxService.Stop();
                    lblServiceStatus.Text       = "STOPPED";                    
                    lblServiceStatus.ForeColor  = Color.IndianRed;

                    btnRunStop.Text             = "Pokreni Servis".ToUpper();
                    btnRunStop.BackColor        = SystemColors.Highlight;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem sa servisom: " + ex.Message);
            }
        }
    }
}
