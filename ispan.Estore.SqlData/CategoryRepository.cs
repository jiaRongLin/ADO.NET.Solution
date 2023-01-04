using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;
using static ispan.Estore.SqlData.CategoryRepository;

namespace ispan.Estore.SqlData
{
    public class CategoryRepository
    {
        public Category GetCategory(int categoryId)
        {
            using (var conn = SQLDb.GetConnection())
            {
                Category category = null;
                string sql = $"select * from Categories where id ={categoryId}";
                using (var commad = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    var reader = commad.ExecuteReader();
                    if (reader.Read())
                    {
                        return Category.GetInstance(reader);
                        //category = new Category
                        //{
                        //    Id = categoryId,
                        //    Name = reader.GetFieldValue<string>("Name"),
                        //    DisplayOrder = reader.GetFieldValue<int>("DisplayOrder")
                        //    //Id = categoryId,
                        //    //Name = reader.["Name"].ToString(),
                        //    //DisplayOrder = int.Parse(reader["DisplayOrder"].ToString())
                        //};
                    }
                }
                return category;
            }
        }

        public int GetProductCount(int categoryId)
        {
            using (var conn = SQLDb.GetConnection())
            {
                string sql = $"select count(*) from Products where Categoryid ={categoryId}";
                using (var commad = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    object result = commad.ExecuteScalar();
                    return Convert.ToInt32(result);
                }
            }
        }
    }
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DisplayOrder { get; set; }

        public static Category GetInstance(SqlDataReader reader)
        {
            return new Category
            {
                Id = reader.GetFieldValue<int>("Id"),
                Name = reader.GetFieldValue<string>("Name"),
                DisplayOrder = reader.GetFieldValue<int>("DisplayOrder")
            };
        }
    }
    public static class SqlDataReaderExtensions
    {
        public static T GetFieldValue<T>(this SqlDataReader source,string columnName)
           =>source[columnName].Equals(DBNull.Value)
                 ? default(T): (T)source[columnName];
        //{
        //T defaultValue = default;
        //if (source[columnName].Equals(DBNull.Value))
        //{
        //    return defaultValue;
        //}

        //return (T)source[columnName];
        //}
    }
}
