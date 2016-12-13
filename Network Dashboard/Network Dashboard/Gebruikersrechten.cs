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
        Gebruiker IngelogdeGebruiker;

        public Gebruikersrechten(Gebruiker ingelogdeGebruiker)
        {
            InitializeComponent();
            this.IngelogdeGebruiker = ingelogdeGebruiker;
            if (ingelogdeGebruiker.Recht != "BEHEERDER")
            {
                btn_veranderRecht.Enabled = false;
                lb_Gebruikers.Enabled = false;
                cb_Recht.Enabled = false;
            }
            else
            {
                UpdateGebruikers();
            }

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
            StartMenu menu = new StartMenu(IngelogdeGebruiker);
            menu.Show();
        }

        private void UpdateGebruikers()
        {
            try
            {
                lb_Gebruikers.Items.Clear();
                foreach (Gebruiker g in DbQueries.GetGebruikers())
                {
                    lb_Gebruikers.Items.Add(g);
                }
            }
            catch (Exception ex)
            {
                EventLogging.LogMessageToFile(ex.Message);
                MessageBox.Show("De nieuwe gebruikers zijn niet geladen. Check uw connectie met de database.");
            }
        }

        private void btn_veranderRecht_Click(object sender, EventArgs e)
        {
            try
            {
                string[] gebruiker = lb_Gebruikers.SelectedItem.ToString().Split(',');
                Gebruiker g = new Gebruiker(gebruiker[0], cb_Recht.SelectedItem.ToString());
                if (IngelogdeGebruiker.Recht == "BEHEERDER")
                {
                    if (gebruiker[1] != "BEHEERDER")
                    {
                        DbQueries.WijzigRecht(g);
                        MessageBox.Show("Het recht van het account '" + gebruiker[0] + "' is veranderd naar '" + cb_Recht.SelectedItem.ToString() + "'.");
                    }
                    else
                    {
                        MessageBox.Show("Deze gebruiker is een Beheerder, u kunt het recht van deze gebruiker niet veranderen zonder toegang tot de database.");
                    }
                }
                else
                {
                    MessageBox.Show("U heeft het recht: " + IngelogdeGebruiker.Recht + ", daarom bent u niet bevoegd om rechten te veranderen.",  "Geen bevoegdheid.");
                }
                
            }
            catch(Exception ex)
            {
                EventLogging.LogMessageToFile(ex.Message);
                MessageBox.Show("Er is een fout opgetreden tijdens het veranderen van het recht.");
                
            }
            UpdateGebruikers();
        }

        private void btn_updateSpeed_Click(object sender, EventArgs e)
        {
            if (!NetworkInterface.GetIsNetworkAvailable())
                return;

            NetworkInterface[] interfaces = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface NI in interfaces)
            {
                Console.WriteLine(" Bytes sent: {0}", NI.GetIPv4Statistics().BytesSent);
                Console.WriteLine(" Bytes received: {0}", NI.GetIPv4Statistics().BytesReceived);
            }

        }
    }
}
