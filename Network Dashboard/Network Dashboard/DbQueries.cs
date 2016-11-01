using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Oracle.ManagedDataAccess.Client;
namespace Network_Dashboard
{
    public class DbQueries
    {
        public void CreateGebruiker(string gebruikersnaam, string wachtwoord)
        {
           string connString = "Data Source=192.168.15.50:1521/fhictora; User Id=dbi319035; Password=deathispeace;";
            using (OracleConnection connection = new OracleConnection(connString))
            {
                connection.Open();
                OracleCommand cmd = new OracleCommand("INSERT INTO Gebruiker (gebruikersnaam, wachtwoord) VALUES ('" + gebruikersnaam + "', '" + wachtwoord + "')", connection);
                cmd.ExecuteNonQuery();

            }
           
        }
        public Gebruiker InloggenGebruiker(string gebruikersnaam, string wachtwoord)
        {
            Gebruiker gebruiker = null;
            string connString = "Data Source=192.168.15.50:1521/fhictora; User Id=dbi319035; Password=deathispeace;";
            using (OracleConnection connection = new OracleConnection(connString))
            {
                connection.Open();
                OracleCommand cmd = new OracleCommand("Select * FROM Gebruiker WHERE gebruikersnaam = '" + gebruikersnaam + "' AND wachtwoord = '" + wachtwoord + "'", connection);
                using (OracleDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        gebruikersnaam = reader["gebruikersnaam"].ToString();
                        wachtwoord = reader["wachtwoord"].ToString();
                        string id = reader["id"].ToString();
                        string recht = reader["id"].ToString();
                        gebruiker = new Gebruiker(id, gebruikersnaam, wachtwoord, recht);
                    }
                }
                return gebruiker;
            }



        }
        public void WijzigWachtwoord(string gebruikersnaam, string wachtwoord)
        {
            string connString = "Data Source=192.168.15.50:1521/fhictora; User Id=dbi319035; Password=deathispeace;";
            using (OracleConnection connection = new OracleConnection(connString))
            {
                connection.Open();
                OracleCommand cmd = new OracleCommand("UPDATE Gebruiker SET wachtwoord = '" + wachtwoord + "' WHERE gebruikersnaam = '" + gebruikersnaam + "'", connection);
                cmd.ExecuteNonQuery();

            }
        }
    
        private List<Gebruiker> DataTableToUserList(DataTable userTable)
        {
            try
            {
                List<Gebruiker> gebruikerslijst = new List<Gebruiker>();
                string id = userTable.Rows[0][0].ToString();
                string gebruikersnaam = userTable.Rows[0][2].ToString();
                string wachtwoord = userTable.Rows[0][4].ToString();
                string recht = userTable.Rows[0][7].ToString();
                return gebruikerslijst;
            }
            catch
            {
                return null;
            }
        }


    }
}
