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
        Advies advies;
        private bool poort = false, gebruikersrecht = false, blacklist = false, data = false, ingelogd = false;

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
                    btn_gebruikersrechten.Enabled = false;
                    btn_datagebruik.Enabled = false;
                    btn_gebruikersrechten.Enabled = false;
                    break;
                case "BEPERKT":
                    lbl_ingelogdeGebruiker.Text = "U bent ingelogd als: " + ingelogdeGebruiker.Inlognaam;
                    btn_datagebruik.Enabled = false;
                    btn_Blacklisting.Enabled = false;
                    btn_poortscanner.Enabled = false;
                    btn_gebruikersrechten.Enabled = false;
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

        private void pb_smHelpIngelogd_Click(object sender, EventArgs e)
        {
            switch (this.ingelogd)
            {
                case false:
                    lb_smHelpIngelogd.Location = new Point(pb_smHelpIngelogd.Location.X, (pb_smHelpIngelogd.Location.Y + 16));
                    lb_smHelpIngelogd.Visible = true;
                    advies = new Advies("smHelpIngelogd");
                    lb_smHelpIngelogd.Text = advies.GetAdvies();
                    this.ingelogd = true;
                    break;
                case true:
                    lb_smHelpIngelogd.Visible = false;
                    this.ingelogd = false;
                    break;
                default:
                    MessageBox.Show("Er is iets foutgegaan met het advies.");
                    break;
            }
        }

        private void pb_smHelpBlacklist_Click(object sender, EventArgs e)
        {
            switch (this.blacklist)
            {
                case false:
                    lb_smHelpBlacklist.Location = new Point(pb_smHelpBlacklist.Location.X, (pb_smHelpBlacklist.Location.Y + 16));
                    lb_smHelpBlacklist.Visible = true;
                    advies = new Advies("smHelpBlacklist");
                    lb_smHelpBlacklist.Text = advies.GetAdvies();
                    this.blacklist = true;
                    break;
                case true:
                    lb_smHelpBlacklist.Visible = false;
                    this.blacklist = false;
                    break;
                default:
                    MessageBox.Show("Er is iets foutgegaan met het advies.");
                    break;
            }
        }

        private void pb_smHelpGebruikersrecht_Click(object sender, EventArgs e)
        {
            switch (this.gebruikersrecht)
            {
                case false:
                    lb_smHelpGebruikersrecht.Location = new Point(pb_smHelpGebruikersrecht.Location.X, (pb_smHelpGebruikersrecht.Location.Y + 16));
                    lb_smHelpGebruikersrecht.Visible = true;
                    advies = new Advies("smHelpGebruikersrecht");
                    lb_smHelpGebruikersrecht.Text = advies.GetAdvies();
                    this.gebruikersrecht = true;
                    break;
                case true:
                    lb_smHelpGebruikersrecht.Visible = false;
                    this.gebruikersrecht = false;
                    break;
                default:
                    MessageBox.Show("Er is iets foutgegaan met het advies.");
                    break;
            }
        }

        private void pb_smHelpData_Click(object sender, EventArgs e)
        {
            switch (this.data)
            {
                case false:
                    lb_smHelpData.Location = new Point(pb_smHelpData.Location.X, (pb_smHelpData.Location.Y + 16));
                    lb_smHelpData.Visible = true;
                    advies = new Advies("smHelpData");
                    lb_smHelpData.Text = advies.GetAdvies();
                    this.data = true;
                    break;
                case true:
                    lb_smHelpData.Visible = false;
                    this.data = false;
                    break;
                default:
                    MessageBox.Show("Er is iets foutgegaan met het advies.");
                    break;
            }
        }

        private void btn_uitloggen_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
        }

        private void btn_Blacklisting_Click(object sender, EventArgs e)
        {
            this.Hide();
            Blacklisting blacklisting = new Blacklisting(this.IngelogdeGebruiker);
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

        private void pb_smPoort_Click(object sender, EventArgs e)
        {
            switch (this.poort)
            {
                case false:
                    lb_smHelpPoort.Location = new Point(pb_smHelpPoort.Location.X, (pb_smHelpPoort.Location.Y + 16));
                    lb_smHelpPoort.Visible = true;
                    advies = new Advies("smHelpPoort");
                    lb_smHelpPoort.Text = advies.GetAdvies();
                    this.poort = true;
                    break;
                case true:
                    lb_smHelpPoort.Visible = false;
                    this.poort = false;
                    break;
                default:
                    MessageBox.Show("Er is iets foutgegaan met het advies.");
                    break;
            }
        }
    }
}
