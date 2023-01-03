using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ispan.Estore.SqlData
{
    public class SQLDb
    {
        public static string GetConnectionString(string keyOfConnString)
        {
            var node =System.Configuration.ConfigurationManager
                               .ConnectionStrings[keyOfConnString];
            if (node == null) throw new Exception($"找不到節點{keyOfConnString},請再確認一次");
            string connStr = node.ToString();
            return connStr;
        }
    }
}
