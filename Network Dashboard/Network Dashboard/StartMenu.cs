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
    public partial class StartMenu : Form
    {
        Gebruiker IngelogdeGebruiker;
        public StartMenu(Gebruiker ingelogdeGebruiker)
        {
            InitializeComponent();
            this.IngelogdeGebruiker = ingelogdeGebruiker;
            switch (ingelogdeGebruiker.Recht)
            {
                case "BEHEERDER":
                    lbl_ingelogdeGebruiker.Text = "U bent ingelogd als: " + ingelogdeGebruiker.Inlognaam;
                    break;
                case "STANDAARD":
                    lbl_ingelogdeGebruiker.Text = "U bent ingelogd als: " + ingelogdeGebruiker.Inlognaam;
                    btn_Blacklisting.Enabled = false;
                    break;
                case "BEPERKT":
                    lbl_ingelogdeGebruiker.Text = "U bent ingelogd als: " + ingelogdeGebruiker.Inlognaam;
                    btn_Blacklisting.Enabled = false;
                    btn_poortscanner.Enabled = false;
                    break;
                default:
                    lbl_ingelogdeGebruiker.Text = "U bent niet ingelogd als een gebruiker.";
                    break;
            }
        }

        private void btn_poortscanner_Click(object sender, EventArgs e)
        {

                this.Hide();
                Poortscanner poortscanner = new Poortscanner(IngelogdeGebruiker);
                poortscanner.Show();

        }

        private void btn_Blacklisting_Click(object sender, EventArgs e)
        {
            this.Hide();
            Blacklisting blacklisting = new Blacklisting();
            blacklisting.Show();
        }

        private void btn_gebruikersrechten_Click(object sender, EventArgs e)
        {
            this.Hide();
            Gebruikersrechten gebruikersrechten = new Gebruikersrechten(IngelogdeGebruiker);
            gebruikersrechten.Show();
        }

        private void btn_datagebruik_Click(object sender, EventArgs e)
        {
            this.Hide();
            Datagebruik datagebruik = new Datagebruik(IngelogdeGebruiker);
            datagebruik.Show();
        }
    }
}
