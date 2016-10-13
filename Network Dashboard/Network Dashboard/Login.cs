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
    public partial class Login : Form
    {
        DbQueries queries = new DbQueries();
        public Login()
        {
            InitializeComponent();
            
        }

        private void btn_inloggen_Click(object sender, EventArgs e)
        {
            queries.InloggenGebruiker(tb_gebruikersnaam.Text, tb_wachtwoord.Text);
            for (int i = 0; i < 3; i++)
            {
                if (queries == null)
                {
                    MessageBox.Show("Ingevoerde gebruikersnaam en Wachtwoord komen niet overeen");
                    if (i == 3)
                    {
                        MessageBox.Show("U hebt 3 keer verkeerd ingelogd, wilt u het wachtwoord wijzigen?");
                        btn_wijzigwachtwoord.Enabled = true;
                        btn_wijzigwachtwoord.Visible = true;
                    }
                }
                else
                {
                    
                    this.Hide();
                    Poortscanner portscanform = new Poortscanner();
                    portscanform.Show();
                    break;
                }
            }
        }

        private void btn_creategebruiker_Click(object sender, EventArgs e)
        {
            
            queries.CreateGebruiker(tb_gebruikersnaam.Text, tb_wachtwoord.Text);
            MessageBox.Show("Uw account is aangemaakt");
        }

        private void btn_wijzigwachtwoord_Click(object sender, EventArgs e)
        {
            queries.WijzigWachtwoord(tb_gebruikersnaam.Text, tb_wachtwoord.Text);
            MessageBox.Show("Uw wachtwoord is gewijzigd"); 
        }
    }
}
