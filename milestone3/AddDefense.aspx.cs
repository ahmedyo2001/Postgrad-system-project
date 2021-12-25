using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace milestone3
{
    public partial class AddDefense : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Gucian(object sender, EventArgs e)
        {
            Response.Redirect("AddDefenseGucian.aspx");
        }
        protected void NonGucian(object sender, EventArgs e)
        {
            Response.Redirect("AddDefenseNonGucian.aspx");
        }
    }
}