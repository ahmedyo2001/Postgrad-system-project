using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace milestone3
{
	public partial class landing_page1 : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

        protected void supRegRed(object sender, EventArgs e)
        {
            Response.Redirect("Supervisor Register.aspx");
        }

        protected void stuRegRed(object sender, EventArgs e)
        {
            Response.Redirect("Student Register.aspx");
        }
        protected void loginRed(object sender, EventArgs e)
        {
            Response.Redirect("login.aspx");
        }
    }
}