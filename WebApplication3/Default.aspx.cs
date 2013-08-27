using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data;
using System.Data.Common;
using System.Data;

using WebApplication3.Model.Northwind;
using System.Configuration;

namespace WebApplication3
{
	public partial class Default : System.Web.UI.Page
	{
		private String connectionString;

		protected void Page_Load(object sender, EventArgs e)
		{
			if (!IsPostBack) InitPage();

			Test2();
		}

		protected void InitPage()
		{
			connectionString = ConfigurationManager.ConnectionStrings["MySqlConn"].ConnectionString;
		}

		private void Test2()
		{
			NorthwindContext north = new NorthwindContext(connectionString);
			//north.
			var suppliers = from Supplier in north.Suppliers select Supplier;

			foreach (var s in suppliers)
			{
				Response.Write(s.ContactName + ", " + s.CompanyName + ", " + s.City + "<br />");
			}

			north.Dispose();
		}

		private void Test1()
		{
			var conn = new MySql.Data.MySqlClient.MySqlConnection(connectionString);
			conn.Open();

			var cmd = conn.CreateCommand();
			cmd.CommandText = "select * from customers";

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
	}
}