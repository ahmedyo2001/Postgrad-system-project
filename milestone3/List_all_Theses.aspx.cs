using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Windows;
using EO.WebBrowser.DOM;

namespace milestone3
{
    public partial class List_all_Theses : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connstr = WebConfigurationManager.ConnectionStrings["milestone3"].ToString();
            SqlConnection conn = new SqlConnection(connstr);
            SqlCommand SupViewProfileproc = new SqlCommand("AdminViewAllTheses", conn);
            SupViewProfileproc.CommandType = CommandType.StoredProcedure;


            conn.Open();
            SqlDataReader reader = SupViewProfileproc.ExecuteReader();
            GridView1.DataSource = reader;
            GridView1.DataBind();
            conn.Close();
        }

        protected void Back_Click(object sender, EventArgs e)
        {
            Response.Redirect("admin_main.aspx");
        }
    }
}