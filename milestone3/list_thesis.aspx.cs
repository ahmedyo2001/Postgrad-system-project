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
    public partial class list_thesis_Gucian : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connstr = WebConfigurationManager.ConnectionStrings["milestone3"].ToString();
            SqlConnection conn = new SqlConnection(connstr);

            SqlCommand showThesis = new SqlCommand("showThesis", conn);
            showThesis.CommandType = CommandType.StoredProcedure;
            int id = Int16.Parse(Session["id"].ToString());

            showThesis.Parameters.Add(new SqlParameter("@studentID", id));
            conn.Open();
            SqlDataReader reader = showThesis.ExecuteReader();
            GridView1.DataSource = reader;
            GridView1.DataBind();
            conn.Close();
        }
    }
}