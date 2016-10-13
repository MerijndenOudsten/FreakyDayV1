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
            DataTable account = new DataTable();
            account = DbConnectie.SelecteerData(cmd);
            
            if(DataTableToUserList(account)[0] == null)
            {
                return null;
            }
            else 
            {
                return DataTableToUserList(account)[0];
            }
        }
        public void WijzigWachtwoord(string gebruikersnaam, string wachtwoord)
        {
            OracleCommand cmd = new OracleCommand("UPDATE Gebruiker SET wachtwoord = :wachtwoord WHERE gebruikersnaam = :gebruikersnaam");
            cmd.Parameters.Add("gebruikersnaam", gebruikersnaam);
            cmd.Parameters.Add("wachtwoord", wachtwoord);
            DbConnectie.CommandUitvoeren(cmd);
        }

        private List<Gebruiker> DataTableToUserList(DataTable userTable)
        {
            try {
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
