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
        DbQueries dbq = new DbQueries();

        private const double timerUpdate = 1000;

        private NetworkInterface[] nicArr;

        private Timer timer = new Timer();

        Gebruiker IngelogdeGebruiker;
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


        private void InitializeTimer()
        {
            timer.Interval = (int)timerUpdate;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        private void StopTimer()
        {
            timer.Stop();
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

    }
}
