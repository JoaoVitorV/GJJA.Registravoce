using System.Data;
using System.Data.Common;
using MySql.Data.MySqlClient;

namespace GJJA.RegistraVoce.DataAccess.Utils
{
    public class DbUtils
    {
        public static DbConnection CreateConnection(string connectionString)
        {
            DbConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            return connection;
        }
        public static void CloseConnection(DbConnection conn)
        {
            if (conn != null && conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
    }
}