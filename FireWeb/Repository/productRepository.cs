using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using MySql.Data.MySqlClient;

namespace FireWeb.Repository
{
    public class ProductRepository
    {
        private static MySqlConnection _connect = new BaseConnection().cn;

        public static IEnumerable<string> GetUser()
        {
            return _connect.Query<string>("select distinct(user) from user");
        }
    }
}
