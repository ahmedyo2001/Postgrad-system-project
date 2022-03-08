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
    public partial class Gucian_view_info : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connstr = WebConfigurationManager.ConnectionStrings["milestone3"].ToString();
            SqlConnection conn = new SqlConnection(connstr);

            SqlCommand viewproc = new SqlCommand("viewMyProfile", conn);

            int id = Int16.Parse(Session["id"].ToString());
            viewproc.CommandType = CommandType.StoredProcedure;
            viewproc.Parameters.Add(new SqlParameter("@studentId", id));


            conn.Open();
            SqlDataReader reader = viewproc.ExecuteReader();
            GridView1.DataSource = reader;
            GridView1.DataBind();
            conn.Close();

        }
    }
}