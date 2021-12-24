using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace milestone3
{
    public partial class GucianMain : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
         
        }

        protected void mobile_red(object sender, EventArgs e)
        {
            Response.Redirect("Add Phone Page.aspx");
        }
    }
}