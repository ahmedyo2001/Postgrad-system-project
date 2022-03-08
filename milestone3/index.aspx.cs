using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace milestone3
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void login_Click(object sender, EventArgs e)
        {
            Response.Redirect("login.aspx");
        }

        protected void admin_Click(object sender, EventArgs e)
        {
            Response.Redirect("admin_main.aspx");
        }

        protected void student_Click(object sender, EventArgs e)
        {
            Response.Redirect("student_register.aspx");
        }

        protected void examiner_Click(object sender, EventArgs e)
        {
            Response.Redirect("examiner_register.aspx");
        }

        protected void supervisor_Click(object sender, EventArgs e)
        {
            Response.Redirect("supervisor_register.aspx");
        }
    }
}