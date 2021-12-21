using System.Data;
using System.Data.SqlClient;

namespace DapperHelper
{
    public class ConnectionHelper
    {
        public static IDbConnection GetConnection(string dataBaseName)
        {
            string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=" + dataBaseName + @";Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False";
            return new SqlConnection(connString);
        }

        public static IDbConnection GetConnection(string datasource, string database, string username, string password)
        {
            string connString = @"Data Source=" + datasource + ";Initial Catalog="
                        + database + ";Persist Security Info=True;User ID=" + username + ";Password=" + password;

            SqlConnection conn = new SqlConnection(connString);

            return conn;
        }
    }
}
