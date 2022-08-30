using Microsoft.Data.SqlClient;

namespace SmartwayTestTask.DataAccessLayer.Implementations
{
    public class DBConnection
    {
        private const string CONNECT = @"Data Source=.\SQLEXPRESS; Initial Catalog=SmartwayTestDB; Integrated Security=true; TrustServerCertificate=True";

        public static SqlConnection CreateConnection()
        {
            return new SqlConnection(CONNECT);
        }
    }
}
