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
    public partial class Poortscanner : Form
    {
        Gebruiker IngelogdeGebruiker;
        public Poortscanner(Gebruiker ingelogdeGebruiker)
        {
            InitializeComponent();
            this.IngelogdeGebruiker = ingelogdeGebruiker;
            switch (ingelogdeGebruiker.Recht)
            {
                case "STANDAARD":
                    Poortscanning();
                    break;
                case "BEHEERDER":
                    Poortscanning();
                    break;
                default:
                    break;
            }
            Poortscanning();
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

        private void btn_backtostartmenu_Click(object sender, EventArgs e)
        {
            this.Close();
            StartMenu startmenu = new StartMenu(IngelogdeGebruiker);
            startmenu.Show();
        }
    }
}

