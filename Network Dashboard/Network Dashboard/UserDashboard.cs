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
        private const double timerUpdate = 500;

        NetworkInterface currNetwork = null;

        private Timer timer = new Timer();

        private int getUpload;
        private int getDownload;

        Dataverbruik dataver;

        IPv4InterfaceStatistics interfaceStats;

        Gebruiker IngelogdeGebruiker;

        public UserDashboard(Gebruiker ingelogdeGebruiker)
        {
            InitializeComponent();
            chart_Dataverbruik.ChartAreas[0].AxisY.Maximum = 1000000;

            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (nic.Name.ToString() == "Wi-Fi")
                {
                    currNetwork = nic;

                    interfaceStats = currNetwork.GetIPv4Statistics();
                }
            }
            Poortscanning();
            InitializeTimer();
            this.IngelogdeGebruiker = ingelogdeGebruiker;



        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void btn_LoadGraph_Click(object sender, EventArgs e)
        {

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
                int bytesSent = (int)interfaceStats.BytesSent / 1000000;
                int bytesReceived = (int)interfaceStats.BytesReceived / 1000000;
                dataver = new Dataverbruik(bytesSent, bytesReceived, this.IngelogdeGebruiker, System.DateTime.Today.ToShortDateString());

                DbQueries.CreateDataGebruik(dataver);


                getUpload = DbQueries.GetUploadverbruik(IngelogdeGebruiker.Inlognaam);
                getDownload = DbQueries.GetDownloadverbruik(IngelogdeGebruiker.Inlognaam);


                chart_Dataverbruik.Series[0].Points.AddXY(System.DateTime.Today, getUpload);
                chart_Dataverbruik.Series[1].Points.AddXY(System.DateTime.Today, getDownload);

                Refresh();

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
                    break;
                case "STANDAARD":
                    break;
                case "BEHEERDER":
                    startmenu = new StartMenu(IngelogdeGebruiker);
                    startmenu.Show();
                    break;
            }
        }

        public void Poortscanning()
        {
            Portscan http = new Portscan(80);
            Portscan ftp = new Portscan(21);
            Portscan telnet = new Portscan(23);
            Portscan pop3 = new Portscan(110);
            Portscan smtp = new Portscan(25);


            if (http.StartScan() == "open")
            {
                cb_httpopen.Checked = true;
                cb_httpclosed.Checked = false;
            }
            else
            {
                cb_httpopen.Checked = false;
                cb_httpclosed.Checked = true;
            }
            if (ftp.StartScan() == "open")
            {
                cb_ftpopen.Checked = true;
                cb_ftpclosed.Checked = false;
            }
            else
            {
                cb_ftpopen.Checked = false;
                cb_ftpclosed.Checked = true;
            }
            if (telnet.StartScan() == "open")
            {
                cb_telnetopen.Checked = true;
                cb_telnetclosed.Checked = false;
            }
            else
            {
                cb_telnetopen.Checked = false;
                cb_telnetclosed.Checked = true;
            }
            if (pop3.StartScan() == "open")
            {
                cb_pop3open.Checked = true;
                cb_pop3closed.Checked = false;
            }
            else
            {
                cb_pop3open.Checked = false;
                cb_pop3closed.Checked = true;
            }
            if (smtp.StartScan() == "open")
            {
                cb_smtpopen.Checked = true;
                cb_smtpclosed.Checked = false;
            }
            else
            {
                cb_smtpopen.Checked = false;
                cb_smtpclosed.Checked = true;
            }


        }

        private void btn_Uitloggen_Click(object sender, EventArgs e)
        {
            StopTimer();
            this.Close();
            Login login = new Login();
            login.Show();
        }
    }
}


