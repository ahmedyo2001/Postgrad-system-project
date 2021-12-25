using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace milestone3
{
    public partial class Gucian_home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void viewInfo(object sender, EventArgs e)
        {
            

            Response.Redirect("Gucian_view_info.aspx");




        }

        protected void list_thesis(object sender, EventArgs e)
        {

            Response.Redirect("list_thesis_Gucian.aspx");

        }

        protected void progress_report(object sender, EventArgs e)
        {
            Response.Redirect("progress_report_Gucian.aspx");


        }

        protected void Publication(object sender, EventArgs e)
        {

            Response.Redirect("Gucian_publication.aspx");

        }


    }
}