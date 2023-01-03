using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ispan.Estore.SqlData
{
    public class SQLDb
    {
        public static string ApplicationName { get; set; }
        public static int ConnectTimeout { get; set; }
        public static bool? Pooling { get; set; }
        public static string GetConnectionString(string keyOfConnString)
        {
            var node =System.Configuration.ConfigurationManager
                               .ConnectionStrings[keyOfConnString];
            if (node == null) throw new Exception($"找不到節點{keyOfConnString},請再確認一次");
            string connStr = node.ToString();

            var sb = new SqlConnectionStringBuilder(connStr);
            if (string.IsNullOrEmpty(ApplicationName)==false) sb.ApplicationName = ApplicationName;
            if (ConnectTimeout>0) sb.ConnectTimeout = ConnectTimeout;
            if (Pooling.HasValue)sb.Pooling = Pooling.Value;
            
            return sb.ToString();
        }
        public static SqlConnection GetConnection(string keyOfConnString = "default")
        {
            string connStr = GetConnectionString(keyOfConnString);
            return new SqlConnection(connStr); //建立一個SqlConnection物件並傳回
        }
    }
}
