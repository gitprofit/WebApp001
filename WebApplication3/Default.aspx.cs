using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace WebApplication3
{
	public partial class Default : System.Web.UI.Page
	{

		protected void Page_Load(object sender, EventArgs e)
		{
			if (!IsPostBack) InitPage();

			//
		}

		protected void InitPage()
		{
			var para = new Util.MySqlConnectionParams();

			para.Host = "st-2013-130.staz.comarch";
			para.Port = "1521";
			para.SID = "orcl";
			para.Username = "APEX_PUBLIC_USER";
			// kurwa mac
			para.Password = "Root123!";
		}
	}
}