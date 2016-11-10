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


namespace Network_Dashboard
{
    public partial class Login : Form
    {
        DbQueries queries = new DbQueries();
        int i = 0;
        public Login()
        {
            InitializeComponent();

        }

        private void btn_inloggen_Click(object sender, EventArgs e)
        {

            Gebruiker gebruiker = queries.InloggenGebruiker(tb_gebruikersnaam.Text, tb_wachtwoord.Text);

            if (gebruiker == null && i <= 1)
            {
                MessageBox.Show("Ingevoerde gebruikersnaam en wachtwoord komen niet overeen");
                i++;
            }
            else if (gebruiker == null && i >= 2)
            {
                MessageBox.Show("U hebt " + (i + 1).ToString() + " keer verkeerd ingelogd, wilt u het wachtwoord wijzigen?");
                btn_wijzigwachtwoord.Enabled = true;
                btn_wijzigwachtwoord.Visible = true;
                i++;

            }
            else
            {
                StartMenu startmenu = new StartMenu();
                startmenu.Show();
                this.Hide();

            }
        }


        private void btn_creategebruiker_Click(object sender, EventArgs e)
        {

            try
            {
                queries.CreateGebruiker(tb_gebruikersnaam.Text, tb_wachtwoord.Text);
                MessageBox.Show("Uw account is aangemaakt");
            }
            catch
            {
                MessageBox.Show("gg");
            }

        }

        private void btn_wijzigwachtwoord_Click(object sender, EventArgs e)
        {
            try
            {

                queries.WijzigWachtwoord(tb_gebruikersnaam.Text, tb_wachtwoord.Text);
                MessageBox.Show("Uw wachtwoord is gewijzigd");
            }
            catch
            {
                MessageBox.Show("Uw wachtwoord voldoet niet aan de gestelde eisen.");
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

                    OracleDataReader reader = command.ExecuteReader();

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
                    reader.Close();
                    connection.Close();
                }
            }
            catch
            {
                Console.Write("Message");

            }

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
