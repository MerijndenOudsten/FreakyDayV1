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
            OracleCommand cmd = new OracleCommand("INSERT INTO Gebruiker (gebruikersnaam, wachtwoord, recht) VALUES (:gebruikersnaam, :wachtwoord)");
            cmd.Parameters.Add("gebruikersnaam", gebruikersnaam);
            cmd.Parameters.Add("wachtwoord", wachtwoord);
            DbConnectie.CommandUitvoeren(cmd);
        }
        public Gebruiker InloggenGebruiker(string gebruikersnaam, string wachtwoord)
        {
            OracleCommand cmd = new OracleCommand("Select gebruikersnaam, wachtwoord FROM Gebruiker WHERE gebruikersnaam = :gebruikersnaam AND wachtwoord = :wachtwoord");
            cmd.Parameters.Add("gebruikersnaam", gebruikersnaam);
            cmd.Parameters.Add("wachtwoord", wachtwoord);
            //DataTable account = new DataTable();
            //account = DbConnectie.SelecteerData(cmd);
            try 
            {
                if (DataTableToUserList(cmd)[0] == null)
                {
                    return null;
                }
                else
                {
                    return DataTableToUserList(cmd)[0];
                }
            }
            catch
            {
                return null;
            }
        }
        public void WijzigWachtwoord(string gebruikersnaam, string wachtwoord)
        {
            OracleCommand cmd = new OracleCommand("UPDATE Gebruiker SET wachtwoord = :wachtwoord WHERE gebruikersnaam = :gebruikersnaam");
            cmd.Parameters.Add("gebruikersnaam", gebruikersnaam);
            cmd.Parameters.Add("wachtwoord", wachtwoord);
            DbConnectie.CommandUitvoeren(cmd);
        }

        private List<Gebruiker> DataTableToUserList(OracleCommand command)
        {
            try 
            {
                OracleConnection connection = new OracleConnection("Data Source=192.168.15.50:1521/fhictora;User Id=dbi319035;Password=deathispeace;");
                connection.Open();
                OracleCommand cmd = new OracleCommand("Select gebruikersnaam, wachtwoord FROM Gebruiker WHERE gebruikersnaam = :gebruikersnaam AND wachtwoord = :wachtwoord");
                cmd.Parameters.Add("gebruikersnaam", gebruikersnaam);
                cmd.Parameters.Add("wachtwoord", wachtwoord);
                OracleDataReader reader = command.ExecuteReader();
                
                List<Gebruiker> gebruikerslijst = new List<Gebruiker>();
                while(reader.Read())
                {
                    string id = reader["id"].ToString();
                    string gebruikersnaam = reader["gebruikersnaam"].ToString();
                    string wachtwoord = reader["wachtwoord"].ToString();
                    string recht = reader["recht"].ToString();
                    gebruikerslijst.Add(new Gebruiker(id, gebruikersnaam, wachtwoord, recht));
                }
                connection.Close();
                return gebruikerslijst;
            }
            catch
            {
                return null;
            }
        }

        
    }
}
