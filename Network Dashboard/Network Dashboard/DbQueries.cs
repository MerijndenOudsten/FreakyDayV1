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
        private static string connString = "Data Source=192.168.15.50:1521/fhictora; User Id=dbi319035; Password=deathispeace;";


        public void CreateGebruiker(string gebruikersnaam, string wachtwoord)
        {
           
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
                        string recht = reader["recht"].ToString();
                        gebruiker = new Gebruiker(id, gebruikersnaam, wachtwoord, recht);
                    }
                }
                return gebruiker;
            }



        }
        public void WijzigWachtwoord(string gebruikersnaam, string wachtwoord)
        {
            using (OracleConnection connection = new OracleConnection(connString))
            {
                connection.Open();
                OracleCommand cmd = new OracleCommand("UPDATE Gebruiker SET wachtwoord = '" + wachtwoord + "' WHERE gebruikersnaam = '" + gebruikersnaam + "'", connection);
                cmd.ExecuteNonQuery();

            }
        }


        public List<Gebruiker> GetGebruikers()
        {
            List<Gebruiker> Gebruikers = new List<Gebruiker>();
            Gebruiker gebruiker;
            using (OracleConnection connection = new OracleConnection(connString))
            {
                connection.Open();
                OracleCommand cmd = new OracleCommand("SELECT * FROM gebruiker", connection);
                OracleDataReader reader = cmd.ExecuteReader();
                
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            string gebruikersnaam = reader["gebruikersnaam"].ToString();
                            string recht = reader["recht"].ToString();

                            gebruiker = new Gebruiker(gebruikersnaam, recht);
                            Gebruikers.Add(gebruiker);
                        }
                    }
                return Gebruikers;
            }
         }

        public bool WijzigRecht(Gebruiker g)
        {
            try 
            {
                using (OracleConnection connection = new OracleConnection(connString))
                {
                    connection.Open();
                    OracleCommand cmd = new OracleCommand("UPDATE Gebruiker SET recht = '" + g.Recht + "' WHERE gebruikersnaam = '" + g.Inlognaam + "'", connection);
                    cmd.ExecuteNonQuery();
                    
                }
                return true;
            }
            catch (Exception ex)
            {
                EventLogging.LogMessageToFile(ex.Message);
            }
            return false;
        }
        public void VoegApparaatToe(string macadres, string hostname, int blockedport)
        {
            try
            {

                using (OracleConnection connection = new OracleConnection(connString))
                {
                    connection.Open();
                    OracleCommand cmd = new OracleCommand("INSERT INTO Apparaat (MAC, NAAM, PORT) VALUES ('" + macadres + "', '" + hostname + "', '" + blockedport + "')", connection);
                    cmd.ExecuteNonQuery();
                }
            }
            catch(Exception ex)
            {
                EventLogging.LogMessageToFile(ex.Message);
            }
        }
    }
}
