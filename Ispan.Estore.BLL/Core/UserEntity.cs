using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispan.Estore.BLL.Core
{
	public class UserEntity
	{
		public int Id { get; set; } 
		public string Name { get; }//只有get = 唯讀 必填
		public string Account { get; }
		public string Password { get; }
		public DateTime? DateOfBirth { get; set; }
		public int? Height { get; set; }
		public string Email { get; set; }

		public UserEntity(string name,string account,string password)
		{
			//per conditions
			if (string.IsNullOrEmpty(name)) throw new ArgumentNullException(nameof(name));
			if (string.IsNullOrEmpty(account)) throw new ArgumentNullException(nameof(account));
			if (string.IsNullOrEmpty(password)) throw new ArgumentNullException(nameof(password));

			this.Name = name;
			this.Account = account;
			this.Password = password;
		}

	}
}
