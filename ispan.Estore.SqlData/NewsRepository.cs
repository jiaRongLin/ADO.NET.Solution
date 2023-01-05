using System;
using System.Data;
using System.Data.SqlClient;

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
Set @newId= SCOPE_IDENTITY()";  //取得ID

			//SqlParameter[] parameters = new SqlParameter[]
			//{
			//	new SqlParameter("@Title",System.Data.SqlDbType.NVarChar,50){ Value=entity.Title},
			//	new SqlParameter("@Description",System.Data.SqlDbType.NVarChar,3000){Value=entity.Description},
			//	new SqlParameter("@CreatedTime",System.Data.SqlDbType.DateTime){ Value=entity.CreatedTime},
			//	new SqlParameter("@ModifiedTime",System.Data.SqlDbType.DateTime){Value=entity.ModifiedTime},

			//	new SqlParameter("@newId",System.Data.SqlDbType.Int){ Direction =System.Data.ParameterDirection.Output},
			//};

			SqlParameter[] parameters = SqlParameterBuilder.Create()
				.AddNVarChar("@Title", entity.Title, 50)
				.AddNVarChar("@Description", entity.Description, 3000)
				.AddDateTime("@CreatedTime", entity.CreatedTime)
				.AddDateTime("@ModifiedTime", entity.ModifiedTime)
				.AddInt("@newId", null, ParameterDirection.Output)

				.Build();


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

		public int Delete(int newsId)
		{
			string sql = @"Delete News where Id =@Id";

			SqlParameter[] parameters = SqlParameterBuilder.Create()
				.AddInt("@Id",newsId)
				.Build();
			using (var conn = SQLDb.GetConnection())
			{
				conn.Open();
				using (var cmd =new SqlCommand(sql, conn))
				{
					cmd.Parameters.AddRange(parameters);
					return cmd.ExecuteNonQuery();
				}
			}
		}

		public News GetNews(int newsId)
		{
			var sql = $"Select * from News Where Id ={newsId}";

			using (var conn = SQLDb.GetConnection())
			{
				using (var cmd = new SqlCommand(sql, conn))
				{
					conn.Open();

					var reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
					return reader.Read()
						? News.GetInstance(reader)
						: null;
				}
			}
		}
		public int Update(News entity)
		{
			string sql = @"
Update News
set Title = @Title, Description = @Description,ModifiedTime =@ModifiedTime
where id =@Id;";  


			SqlParameter[] parameters = SqlParameterBuilder.Create()
				.AddNVarChar("@Title", entity.Title, 50)
				.AddNVarChar("@Description", entity.Description, 3000)
				.AddDateTime("@ModifiedTime", entity.ModifiedTime)
				.AddInt("@Id", entity.ID)
				.Build();


			using (var conn = SQLDb.GetConnection())
			{
				conn.Open();
				using (var cmd =new SqlCommand(sql,conn))
				{
					
					cmd.Parameters.AddRange(parameters);

					return cmd.ExecuteNonQuery();

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

		public static News GetInstance(SqlDataReader reader)
		{
			var news = new News();
			news.ID = reader.GetFieldValue<int>("Id");
			news.Title = reader.GetFieldValue<string>("Title");
			news.Description = reader.GetFieldValue<string>("Description");
			news.CreatedTime = reader.GetFieldValue<DateTime>("CreatedTime");
			news.ModifiedTime = reader.GetFieldValue<DateTime>("ModifiedTime");

			return news;
		}
	}
}
