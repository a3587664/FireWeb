using MySql.Data.MySqlClient;

namespace FireWeb.Repository
{
    public class BaseConnection
    {
        public MySqlConnection cn { get; set; }
        public BaseConnection()
        {
            var test = new MySqlConnectionStringBuilder
            {
                Server = "35.206.74.62",
                Port = 3306,
                UserID = "testdb",
                Password = "123qwe",
                Database = "mysql",
                SslMode = MySqlSslMode.None
            };
            cn = new MySqlConnection(test.ToString());
            cn.Open();
        }
    }
}