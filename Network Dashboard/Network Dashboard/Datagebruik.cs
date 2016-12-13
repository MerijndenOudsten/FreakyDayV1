using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;

namespace Network_Dashboard
{
    public partial class Datagebruik : Form
    {

        private const double timerUpdate = 1000;

        private NetworkInterface[] nicArr;

        private Timer timer = new Timer();

        private bool start = false, stop = false, combo = false, snelheid = false, upload = false, download = false;

        public int GebruikteUpload { get; set; }

        public int GebruikteDownload { get; set; }

        Gebruiker IngelogdeGebruiker;

        Advies advies;

        public Datagebruik(Gebruiker IngelogdeGebruiker)
        {
            InitializeComponent();
            this.IngelogdeGebruiker = IngelogdeGebruiker;
            switch (IngelogdeGebruiker.Recht)
            {
                case "BEHEERDER":
                    InitializeNetworkInterface();
                    break;
                case "STANDAARD":
                    InitializeNetworkInterface();
                    break;
                case "BEPERKT":
                    btn_TimerStart.Enabled = false;
                    btn_TimerStop.Enabled = false;
                    cb_NetworkInterfaces.Enabled = false;
                    break;
                default:
                    break;
            }
            InitializeNetworkInterface();
        }

        private void btn_TimerStart_Click(object sender, EventArgs e)
        {
            switch (IngelogdeGebruiker.Recht)
            {
                case "BEHEERDER":
                    InitializeTimer();
                    break;
                case "STANDAARD":
                    InitializeTimer();
                    break;
                default:
                    break;
            }
        }

        private void btn_TimerStop_Click(object sender, EventArgs e)
        {
            StopTimer();
        }

        private void btn_Terug_Click(object sender, EventArgs e)
        {
            this.Close();
            StartMenu menu = new StartMenu(IngelogdeGebruiker);
            menu.Show();
        }

        private void InitializeNetworkInterface()
        {
            // Grab all local interfaces to this computer
            nicArr = NetworkInterface.GetAllNetworkInterfaces();

            // Add each interface name to the combo box
            for (int i = 0; i < nicArr.Length; i++)
            {
                cb_NetworkInterfaces.Items.Add(nicArr[i].Name);
            }

            cb_NetworkInterfaces.SelectedIndex = 0;
        }


        #region DataGebruk picturebox.click help
        private void pb_dgHelpStop_Click(object sender, EventArgs e)
        {
            switch (this.stop)
            {
                case false:
                    lb_dgHelpStop.Location = new Point(pb_dgHelpStop.Location.X, (pb_dgHelpStop.Location.Y + 16));
                    lb_dgHelpStop.Visible = true;
                    advies = new Advies("dgHelpStop");
                    lb_dgHelpStop.Text = advies.GetAdvies();
                    this.stop = true;
                    break;
                case true:
                    lb_dgHelpStop.Visible = false;
                    this.stop = false;
                    break;
                default:
                    MessageBox.Show("Er is iets foutgegaan met het advies.");
                    break;
            }
        }

        private void pb_dgHelpCombo_Click(object sender, EventArgs e)
        {
            switch (this.combo)
            {
                case false:
                    lb_dgHelpCombo.Location = new Point(pb_dgHelpCombo.Location.X, (pb_dgHelpCombo.Location.Y + 16));
                    lb_dgHelpCombo.Visible = true;
                    advies = new Advies("dgHelpCombo");
                    lb_dgHelpCombo.Text = advies.GetAdvies();
                    this.combo = true;
                    break;
                case true:
                    lb_dgHelpCombo.Visible = false;
                    this.combo = false;
                    break;
                default:
                    MessageBox.Show("Er is iets foutgegaan met het advies.");
                    break;
            }
        }

        private void pb_dgHelpSnelheid_Click(object sender, EventArgs e)
        {
            switch (this.snelheid)
            {
                case false:
                    lb_dgHelpSnelheid.Location = new Point(pb_dgHelpSnelheid.Location.X, (pb_dgHelpSnelheid.Location.Y + 16));
                    lb_dgHelpSnelheid.Visible = true;
                    advies = new Advies("dgHelpSnelheid");
                    lb_dgHelpSnelheid.Text = advies.GetAdvies();
                    this.snelheid = true;
                    break;
                case true:
                    lb_dgHelpSnelheid.Visible = false;
                    this.snelheid = false;
                    break;
                default:
                    MessageBox.Show("Er is iets foutgegaan met het advies.");
                    break;
            }
        }

        private void pb_dgHelpUpload_Click(object sender, EventArgs e)
        {
            switch (this.upload)
            {
                case false:
                    lb_dgHelpUpload.Location = new Point(pb_dgHelpUpload.Location.X, (pb_dgHelpUpload.Location.Y + 16));
                    lb_dgHelpUpload.Visible = true;
                    advies = new Advies("dgHelpUpload");
                    lb_dgHelpUpload.Text = advies.GetAdvies();
                    this.upload = true;
                    break;
                case true:
                    lb_dgHelpUpload.Visible = false;
                    this.upload = false;
                    break;
                default:
                    MessageBox.Show("Er is iets foutgegaan met het advies.");
                    break;
            }
        }

        private void pb_dgHelpDownload_Click(object sender, EventArgs e)
        {
            switch (this.download)
            {
                case false:
                    lb_dgHelpDownload.Location = new Point(pb_dgHelpDownload.Location.X, (pb_dgHelpDownload.Location.Y + 16));
                    lb_dgHelpDownload.Visible = true;
                    advies = new Advies("dgHelpDownload");
                    lb_dgHelpDownload.Text = advies.GetAdvies();
                    this.download = true;
                    break;
                case true:
                    lb_dgHelpDownload.Visible = false;
                    this.download = false;
                    break;
                default:
                    MessageBox.Show("Er is iets foutgegaan met het advies.");
                    break;
            }
        }
        #endregion



        private void InitializeTimer()
        {
            timer.Interval = (int)timerUpdate;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        private void StopTimer()
        {
            try 
            {
                timer.Stop();
                DbQueries.CreateDataGebruik(this.IngelogdeGebruiker.Inlognaam, System.DateTime.Now.ToString(), this.GebruikteUpload, this.GebruikteDownload);
            }
            catch (Exception ex)
            {
                EventLogging.LogMessageToFile(ex.Message);
            }
        }

        private void UpdateNetworkInterface()
        {
            try
            {
                // Grab NetworkInterface object that describes the current interface
                NetworkInterface nic = nicArr[cb_NetworkInterfaces.SelectedIndex];

                // Grab the stats for that interface
                IPv4InterfaceStatistics interfaceStats = nic.GetIPv4Statistics();

                // Calculate the speed of bytes going in and out
                int bytesSentSpeed = (int)(interfaceStats.BytesSent - double.Parse(lbl_BytesSent.Text)) / 1024;
                int bytesReceivedSpeed = (int)(interfaceStats.BytesReceived - double.Parse(lbl_BytesReceived.Text)) / 1024;

                if(bytesSentSpeed > 0)
                {
                    this.GebruikteUpload = this.GebruikteUpload + bytesSentSpeed;
                }

                if(bytesReceivedSpeed > 0)
                {
                    this.GebruikteDownload = this.GebruikteDownload + bytesReceivedSpeed;
                }



                // Update the labels
                //lblInterfaceType.Text = nic.NetworkInterfaceType.ToString();
                lbl_InternetSnelheid.Text = (nic.Speed / 10000000.0).ToString();
                lbl_BytesReceived.Text = interfaceStats.BytesReceived.ToString();
                lbl_BytesSent.Text = interfaceStats.BytesSent.ToString();
                lbl_Upload.Text = (bytesSentSpeed * 8).ToString() + " Kb/s";
                lbl_Download.Text = (bytesReceivedSpeed * 8).ToString() + " Kb/s";
            }
            catch (Exception ex)
            {
                EventLogging.LogMessageToFile(ex.Message);
            }

        }

        /// <summary>
        /// The Timer event for each Tick (second) to update the UI
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void timer_Tick(object sender, EventArgs e)
        {
            UpdateNetworkInterface();
        }

        private void pb_dgHelpStart_Click(object sender, EventArgs e)
        {
            switch(this.start)
            {
                case false:
                    lb_dgHelpStart.Location = new Point(pb_dgHelpStart.Location.X, (pb_dgHelpStart.Location.Y + 16));
                    lb_dgHelpStart.Visible = true;
                    advies = new Advies("dgHelpStart");
                    lb_dgHelpStart.Text = advies.GetAdvies();
                    this.start = true;
                    break;
                case true:
                    lb_dgHelpStart.Visible = false;
                    this.start = false;
                    break;
                default:
                    MessageBox.Show("Er is iets foutgegaan met het advies.");
                    break;
            }
        }
    }
}
