using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Oracle.DataAccess.Client;

namespace WebApplication3
{
	public partial class Default : System.Web.UI.Page
	{
		private OracleConnection connection;

		protected void Page_Load(object sender, EventArgs e)
		{
			if (!IsPostBack) InitPage();

			//
		}

		protected void InitPage()
		{
			var para = new Util.OracleConnectionParams();

			para.Host = "st-2013-130.staz.comarch";
			para.Port = "1521";
			para.SID = "orcl";
			para.Username = "APEX_PUBLIC_USER";
			para.Password = "Root123!";

			connection = new OracleConnection(para.ConnectionString);
		}
	}
}