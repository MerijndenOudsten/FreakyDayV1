using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Network_Dashboard
{
    public partial class Gebruikersrechten : Form
    {
        DbQueries dbq = new DbQueries();
        public Gebruikersrechten()
        {
            InitializeComponent();
            UpdateGebruikers();
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
    }
}
