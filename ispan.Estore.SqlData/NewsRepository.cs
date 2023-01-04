using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ispan.Estore.SqlData
{
	public class NewsRepository
	{
		public int Create(News entity)
		{
			string sql = @"
Insert into news
(Title, Description , CreatedTime, ModifiedTime)
values
(@Title, @Description , @CreatedTime, @ModifiedTime);
Set @newId= SCOPE_IDENTITY()";

			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@Title",System.Data.SqlDbType.NVarChar,50){ Value=entity.Title},
				new SqlParameter("@Description",System.Data.SqlDbType.NVarChar,3000){Value=entity.Description},
				new SqlParameter("@CreatedTime",System.Data.SqlDbType.DateTime){ Value=entity.CreatedTime},
				new SqlParameter("@ModifiedTime",System.Data.SqlDbType.DateTime){Value=entity.ModifiedTime},

				new SqlParameter("@newId",System.Data.SqlDbType.Int){ Direction =System.Data.ParameterDirection.Output},
			};

			using (var conn = SQLDb.GetConnection())
			{
				using (var cmd = conn.CreateCommand())
				{
					conn.Open();
					cmd.CommandText = sql;
					cmd.Parameters.AddRange(parameters);

					cmd.ExecuteNonQuery();

					return (int)cmd.Parameters["@newId"].Value;
				}
			}
		}
	}

	public class News
	{
		public int ID { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public DateTime CreatedTime { get; set; }
		public DateTime ModifiedTime { get; set; }
	}
}
