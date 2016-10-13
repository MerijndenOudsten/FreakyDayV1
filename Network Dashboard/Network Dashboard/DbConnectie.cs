using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace Network_Dashboard
{
    public class DbConnectie
    {
        private static string connString = "Data Source=192.168.15.50/fhictora;port=1521;User Id=dbi319035;Password=deathispeace;";


        public static DataTable SelecteerData(OracleCommand command)
        {
            try
            {
                DataTable dataTable = new DataTable();

                using (OracleConnection connection = new OracleConnection())
                {
                    connection.ConnectionString = connString;
                    connection.Open();

                    command.Connection = connection;

                    OracleDataReader reader = command.ExecuteReader();
                    dataTable.Load(reader);

                    return dataTable;
                }
            }
            catch (OracleException e)
            {
                Console.Write(e.Message);
                return null;
            }
        }

        public static bool CommandUitvoeren(OracleCommand command)
        {
            try
            {
                using (OracleConnection connection = new OracleConnection())
                {
                    connection.ConnectionString = connString;
                    connection.Open();

                    command.Connection = connection;

                    int check = command.ExecuteNonQuery();

                    if (check > 0)
                    {
                        connection.Close();
                        return true;
                    }
                    else
                    {
                        connection.Close();
                        return false;
                    }
                    
                }
            }
            catch (OracleException e)
            {
                Console.Write(e.Message);
                return false;
            }
        }
    }
}
