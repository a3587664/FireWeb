using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using FireWeb.Models;
using MySql.Data.MySqlClient;

namespace FireWeb.Repository
{
    public class ProductRepository
    {
        private static MySqlConnection _connect = new BaseConnection().cn;

        public static IEnumerable<Interview> GetInterviewInfo()
        {
            return _connect.Query<Interview>("select * from Interview");
        }
    }
}
