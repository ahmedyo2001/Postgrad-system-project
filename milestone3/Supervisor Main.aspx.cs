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
    public partial class Supervisor_Main : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ViewStudentClick(object sender, EventArgs e)
        {
            string connstr = WebConfigurationManager.ConnectionStrings["milestone3"].ToString();
            SqlConnection conn = new SqlConnection(connstr);
            SqlCommand SupViewProfileproc = new SqlCommand("ViewSupStudentsYears", conn);
            SupViewProfileproc.CommandType = CommandType.StoredProcedure;
            int id = Int16.Parse(Session["id"].ToString());
            SupViewProfileproc.Parameters.Add(new SqlParameter("@supervisorID ", id));

            conn.Open();
            SupViewProfileproc.ExecuteNonQuery();
            conn.Close();
            Response.Redirect("Supervisor views student.aspx");
        }
    }
}