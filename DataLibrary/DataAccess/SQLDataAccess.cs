using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace DataLibrary.DataAccess
{
    public static class SQLDataAccess
    {
        public static string GetConnenctionString(string ConnectionName="MVCDatabase")
        {
            return ConfigurationManager.ConnectionStrings[ConnectionName].ConnectionString;
        }

        public static List<T> LoadData<T>(string sql)
        {
            using (IDbConnection connenction=new SqlConnection(GetConnenctionString()))
            {
                return connenction.Query<T>(sql).ToList();
            }
        }

        public static int SaveData<T>(string sql, T data)
        {
            using (IDbConnection connenction = new SqlConnection(GetConnenctionString()))
            {
                return connenction.Execute(sql, data);
            }
        }

    }
}
