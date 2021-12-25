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
    public partial class ViewStudentPublication : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }
        protected void Submission(object sender, EventArgs e)
        {
            String StId = TextBox1.Text;
            string connstr = WebConfigurationManager.ConnectionStrings["milestone3"].ToString();
            SqlConnection conn = new SqlConnection(connstr);
            SqlCommand ViewAStudentPublicationsproc = new SqlCommand("ViewAStudentPublications", conn);
            ViewAStudentPublicationsproc.CommandType = CommandType.StoredProcedure;
            ViewAStudentPublicationsproc.Parameters.Add(new SqlParameter("@studentId ", StId));

            conn.Open();
            SqlDataReader reader = ViewAStudentPublicationsproc.ExecuteReader();
            GridView1.DataSource = reader;
            GridView1.DataBind();
            conn.Close();

        }
    }
}