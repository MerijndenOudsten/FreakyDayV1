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
        public void InloggenGebruiker(string gebruikersnaam, string wachtwoord)
        {
            OracleCommand cmd = new OracleCommand("Select gebruikersnaam, wachtwoord FROM Gebruiker WHERE gebruikersnaam = :gebruikersnaam AND wachtwoord = :wachtwoord");
            cmd.Parameters.Add("gebruikersnaam", gebruikersnaam);
            cmd.Parameters.Add("wachtwoord", wachtwoord);
            DbConnectie.SelecteerData(cmd);
        }
        public void WijzigWachtwoord(string gebruikersnaam, string wachtwoord)
        {
            OracleCommand cmd = new OracleCommand("UPDATE Gebruiker SET wachtwoord = :wachtwoord WHERE gebruikersnaam = :gebruikersnaam");
            cmd.Parameters.Add("gebruikersnaam", gebruikersnaam);
            cmd.Parameters.Add("wachtwoord", wachtwoord);
            DbConnectie.CommandUitvoeren(cmd);
        }
    }
}
