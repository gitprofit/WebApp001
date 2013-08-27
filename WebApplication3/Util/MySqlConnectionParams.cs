using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Util
{
	public class MySqlConnectionParams
	{
		public string Host;
		public string Port;
		public string Username;
		public string Password;
		public string Database;

		public string ConnectionString
		{
			get
			{
				return
						"server=" + Host + ";" +
						"User Id=" + Username + ";" +
						"Password=" + Password + ";" +
						"database=" + Database;
			}
			private set { }
		}
	}

}