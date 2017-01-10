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


    public partial class UserDashboard : Form
    {
        private const double timerUpdate = 1000;
        

        private Timer timer = new Timer();

        Dataverbruik dataver;


        Gebruiker IngelogdeGebruiker;

        public UserDashboard(Gebruiker ingelogdeGebruiker)
        {
            InitializeComponent();
            this.IngelogdeGebruiker = ingelogdeGebruiker;



        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void btn_LoadGraph_Click(object sender, EventArgs e)
        {
            chart_Dataverbruik.Series[0].Points.AddXY(System.DateTime.Today, 5);

        }


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
                //dataver = new Dataverbruik(this.GebruikteUpload, this.GebruikteDownload, this.IngelogdeGebruiker, System.DateTime.Now.ToString());
                DbQueries.CreateDataGebruik(dataver);
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
                NetworkInterface currNetwork = null;
                // Grab NetworkInterface object that describes the current interface
                foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces() )
                {
                    if (nic.Name.ToString() == "Wi-Fi")
                    {
                        currNetwork = nic;
                    }
                }

                // Grab the stats for that interface
                IPv4InterfaceStatistics interfaceStats = currNetwork.GetIPv4Statistics();

                // Calculate the speed of bytes going in and out
                int bytesSentSpeed = (int)interfaceStats.BytesSent;
                int bytesReceivedSpeed = (int)interfaceStats.BytesReceived;





                // Update the labels
                //lblInterfaceType.Text = nic.NetworkInterfaceType.ToString();
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

        private void btn_Menu_Click(object sender, EventArgs e)
        {
            StartMenu startmenu;
            switch (IngelogdeGebruiker.Recht)
            {
                case "BEPERKT":
                    this.Hide();
                    break;
                case "STANDAARD":
                    break;
                case "BEHEERDER":
                    startmenu = new StartMenu(IngelogdeGebruiker);
                    startmenu.Show();
                    this.Hide();
                    break;
            }
        }
    }
}


