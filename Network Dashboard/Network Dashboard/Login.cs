using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using System.IO;


namespace Network_Dashboard
{
    public partial class Login : Form
    {
        int i = 0;
        public Login()
        {
            InitializeComponent();
            this.AcceptButton = btn_inloggen;
        }

        private void btn_inloggen_Click(object sender, EventArgs e)
        {
            try
            {
                Gebruiker gebruiker = DbQueries.InloggenGebruiker(tb_gebruikersnaam.Text, tb_wachtwoord.Text);

                if (gebruiker == null && i <= 1)
                {
                    MessageBox.Show("Ingevoerde gebruikersnaam en wachtwoord komen niet overeen");
                    i++;
                }
                else if (gebruiker == null && i >= 2)
                {
                    MessageBox.Show("U heeft " + (i + 1).ToString() + " keer verkeerd ingelogd, wilt u het wachtwoord wijzigen?");
                    btn_wijzigwachtwoord.Enabled = true;
                    btn_wijzigwachtwoord.Visible = true;
                    i++;

                }
                else
                {
                    UserDashboard userdb;
                    StartMenu sm;
                    switch(gebruiker.Recht)
                    {
                        case "BEPERKT":
                            userdb = new UserDashboard(gebruiker);
                            userdb.Show();
                            this.Hide();
                            break;
                        case "STANDAARD":
                            userdb = new UserDashboard(gebruiker);
                            userdb.Show();
                            this.Hide();
                            break;
                        case "BEHEERDER":
                            sm = new StartMenu(gebruiker);
                            sm.Show();
                            this.Hide();
                            break;
                    }  
                }
            }
            catch(Exception ex)
            {
                EventLogging.LogMessageToFile(ex.Message);
                MessageBox.Show("Er is iets foutgegaan tijdens het inloggen. Check uw connectie met de database.");
            }
            finally
            {
                tb_wachtwoord.Clear();
            }
        }


        private void btn_creategebruiker_Click(object sender, EventArgs e)
        {

            try
            {
                DbQueries.CreateGebruiker(tb_gebruikersnaam.Text, tb_wachtwoord.Text);
                MessageBox.Show("Het account " + tb_gebruikersnaam.Text + " is aangemaakt.");
            }
            catch(Exception ex)
            {
                EventLogging.LogMessageToFile(ex.Message);
                MessageBox.Show("Het account is niet aangemaakt.");
            }

        }

        private void btn_wijzigwachtwoord_Click(object sender, EventArgs e)
        {
            try
            {

                DbQueries.WijzigWachtwoord(tb_gebruikersnaam.Text, tb_wachtwoord.Text);
                MessageBox.Show("Het wachtwoord van " + tb_gebruikersnaam.Text + " is gewijzigd.");
            }
            catch(Exception ex)
            {
                EventLogging.LogMessageToFile(ex.Message);
                MessageBox.Show("Het ingevoerde wachtwoord voldoet niet aan de gestelde eisen.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string connString = "Data Source=192.168.15.50:1521/fhictora;User Id=dbi319035;Password=deathispeace;";
                using (OracleConnection connection = new OracleConnection())
                {
                    connection.ConnectionString = connString;
                    connection.Open();
                    OracleCommand command = new OracleCommand("Select * FROM GEBRUIKER");
                    command.Connection = connection;

                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Console.WriteLine("{0}\t{1}\t{2}", reader.GetInt32(0),
                                    reader.GetString(1), reader.GetString(2));
                            }
                        }
                        else
                        {
                            Console.WriteLine("No rows found.");
                        }
                    }
                    
                }
            }
            catch(Exception ex)
            {

                EventLogging.LogMessageToFile(ex.Message);
            }

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
