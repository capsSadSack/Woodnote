using System.Data;
using System.Data.SqlClient;

namespace DapperHelper
{
    public class ConnectionHelper
    {
        public static IDbConnection GetConnection(string connectionStr)
        {
            //string connString =
            //    @"Data Source=(localdb)\MSSQLLocalDB;" +
            //    $"Initial Catalog={ databaseName };" +
            //    @"Integrated Security=True;" +
            //    "Persist Security Info=False;" +
            //    "Pooling=False;" +
            //    "MultipleActiveResultSets=False;" +
            //    "Connect Timeout=60;" +
            //    "Encrypt=False;" +
            //    "TrustServerCertificate=False";

            return new SqlConnection(connectionStr);
        }

        public static IDbConnection GetConnection(string dataSource, string databaseName, string user, string password)
        {
            string connString =
                $"Data Source={ dataSource };" + 
                $"Initial Catalog={ databaseName };" +
                $"Persist Security Info=True;" +
                $"User ID={ user };" +
                $"Password={ password }";

            SqlConnection conn = new SqlConnection(connString);

            return conn;
        }
    }
}
