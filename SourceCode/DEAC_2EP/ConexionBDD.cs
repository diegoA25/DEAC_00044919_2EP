using System.Data;
using Npgsql;

namespace DEAC_2EP
{
    public static class ConexionBDD
    {
        private static string host = "127.0.0.1",
            database = "Parcial02",
            userId = "postgres",
            password = "abregoC22";

        private static string sConnection =
            $"Server = {host}; Port=5432;User Id={userId};PassWord={password};Database={database};";

        public static DataTable ExecuteQuery(string query)
        {
            NpgsqlConnection connection = new NpgsqlConnection(sConnection);
            DataSet ds = new DataSet();
            
            connection.Open();

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, connection);
            da.Fill(ds);
            
            connection.Close();

            return ds.Tables[0];
        }

        public static void ExecuteNonQuery(string act)
        {
            NpgsqlConnection connection = new NpgsqlConnection(sConnection);
            
            connection.Open();
            
            NpgsqlCommand command = new NpgsqlCommand(act, connection);
            command.ExecuteNonQuery();
            
            connection.Close();
        }
    }
}