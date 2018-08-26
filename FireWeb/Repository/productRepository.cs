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

        internal static IEnumerable<ContactInfo> GetContactInfo()
        {
            var query = "select * from ContactInfo";
            return _connect.Query<ContactInfo>(query);
        }

        internal static void DeleteContactInfo(string name)
        {
            var query = $"delete from ContactInfo where Name = \"{name}\"";
            _connect.Execute(query);
        }

        internal static void DeleteInterviewInfo(string name)
        {
            var query = $"delete from Interview where Position = \"{name}\"";
            _connect.Execute(query);
        }

        internal static void AddInterviewInfo(Interview data)
        {
            var query = $"Insert into Interview (HeadCount,Salary,Education,Experience,Position,Remark) VALUES ('{data.HeadCount}','{data.Salary}','{data.Education}','{data.Experience}','{data.Position}','{data.Remark}')";
            _connect.Execute(query);
        }

        internal static void UpdateInterviewInfo(Interview data)
        {
            var query = $"UPDATE Interview SET HeadCount={data.HeadCount}, Salary=\"{data.Salary}\", Education=\"{data.Education}\", Experience=\"{data.Experience}\", Remark=\"{data.Remark}\" WHERE Position=\"{data.Position}\"";
           _connect.Execute(query);
        }

        internal static void InsertContactInfo(ContactInfo info)
        {
            var query = $"Insert into ContactInfo (Name,CompanyName,CompanyAddress,Mail,Phone,Remark) VALUES ('{info.Name}','{info.CompanyName}','{info.CompanyAddress}','{info.Mail}','{info.Phone}','{info.Remark}')";
            _connect.Execute(query);
        }
    }
}
