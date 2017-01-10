using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace ClientPortApp
{
    class DB
    {
        Apparaat apparaat;
        private static string connString = "Data Source=192.168.15.50:1521/fhictora; User Id=dbi319035; Password=deathispeace;";

        public Apparaat GetBlockedPort(string macadres)
        {
            int blockedport = 0;
            int block = 0;
            try
            {
                using (OracleConnection connection = new OracleConnection(connString))
                {
                    connection.Open();
                    OracleCommand cmd = new OracleCommand("SELECT PORT, BLOCK from APPARAAT WHERE MAC = '" + macadres + "'" ,connection);
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            blockedport = Convert.ToInt32(reader["PORT"]);
                            block = Convert.ToInt32(reader["BLOCK"]);
                        }                     
                    }
                }
                return apparaat = new Apparaat(blockedport, block);
            }
            catch (Exception ex)
            {
                throw ex;            }
        }
        public void DeleteRow(string macadres)
        {
            try
            {
                using (OracleConnection connection = new OracleConnection(connString))
                {
                    connection.Open();
                    OracleCommand cmd = new OracleCommand("DELETE FROM APPARAAT WHERE MAC = '" + macadres + "'", connection);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (OracleException ex)
            {
                Eventlogging.LogMessageToFile(ex.Message);
            }
        }
    }
}

