using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data;
using System.Data.Common;
using System.Data;

namespace WebApplication3
{
	public partial class Default : System.Web.UI.Page
	{
		private String connectionString;

		protected void Page_Load(object sender, EventArgs e)
		{
			if (!IsPostBack) InitPage();

			var conn = new MySql.Data.MySqlClient.MySqlConnection(connectionString);
			conn.Open();

			var cmd = conn.CreateCommand();
			cmd.CommandText = "SELECT * from TestTab";

			var rdr = cmd.ExecuteReader();

			DataTable table = new DataTable();
			table.Load(rdr);

			foreach (DataRow row in table.Rows)
			{
				foreach (DataColumn col in table.Columns)
				{
					Response.Write(row[col.ColumnName] + ", ");
				}
				Response.Write("<br />");
			}
			rdr.Close();
			rdr.Dispose();
			cmd.Dispose();
			conn.Close();
			conn.Dispose();
		}

		protected void InitPage()
		{
			var para = new Util.MySqlConnectionParams();

			para.Host = "mysql.agh.edu.pl";
			para.Port = "3306";
			para.Database = "liszcz1";
			para.Username = "liszcz1";
			para.Password = "4Zs7NG95";

			connectionString = para.ConnectionString;
		}
	}
}