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
		public string SID;

		public string ConnectionString
		{
			get
			{
				return
					"Data Source=" + Host + ":" + Port + "/" + SID + ";" +
					"User Id=" + Username + ";" +
					"Password=" + Password + ";" +
					"Integrated Security=no;";
			}
			private set { }
		}
	}

}