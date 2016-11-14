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
    public partial class Gebruikersrechten : Form
    {
        DbQueries dbq = new DbQueries();

        private const double timerUpdate = 1000;

        private NetworkInterface[] nicArr;

        private Timer timer;


        public Gebruikersrechten()
        {
            InitializeComponent();
            UpdateGebruikers();
            InitializeNetworkInterface();
            InitializeTimer();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Gebruikersrechten_Load(object sender, EventArgs e)
        {

        }

        private void btn_Terug_Click(object sender, EventArgs e)
        {
            this.Close();
            StartMenu menu = new StartMenu();
            menu.Show();
        }

        private void UpdateGebruikers()
        {
            try
            {
                lb_Gebruikers.Items.Clear();
                foreach (Gebruiker g in dbq.GetGebruikers())
                {
                    lb_Gebruikers.Items.Add(g);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("De nieuwe gebruikers zijn niet geladen. Check uw connectie met de database.");
            }
        }

        private void btn_veranderRecht_Click(object sender, EventArgs e)
        {
            try
            {
                string[] gebruiker = lb_Gebruikers.SelectedItem.ToString().Split(',');
                Gebruiker g = new Gebruiker(gebruiker[0], cb_Recht.SelectedItem.ToString());
                if (dbq.WijzigRecht(g))
                {
                    MessageBox.Show("Het recht van het account '" + gebruiker[0] + "' is veranderd naar '" + cb_Recht.SelectedItem.ToString() + "'.");
                }
                
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Er is een fout opgetreden tijdens het veranderen van het recht.");
                
            }
            UpdateGebruikers();
        }

        private void btn_updateSpeed_Click(object sender, EventArgs e)
        {
            if (!NetworkInterface.GetIsNetworkAvailable())
                return;

            NetworkInterface[] interfaces = NetworkInterface.GetAllNetworkInterfaces();
            foreach(NetworkInterface NI in interfaces)
            {
                Console.WriteLine(" Bytes sent: {0}", NI.GetIPv4Statistics().BytesSent);
                Console.WriteLine(" Bytes received: {0}", NI.GetIPv4Statistics().BytesReceived);
            }

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
            timer = new Timer();
            timer.Interval = (int)timerUpdate;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
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
                lbl_BytesReceived.Text = interfaceStats.BytesReceived.ToString() + " bytes";
                lbl_BytesSent.Text = interfaceStats.BytesSent.ToString() + " bytes";
                lbl_Upload.Text = (bytesSentSpeed * 8).ToString() + " Kb/s";
                lbl_Download.Text = (bytesReceivedSpeed * 8).ToString() + " Kb/s";
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
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
