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
    public partial class Supervisor_Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void supReg(object sender, EventArgs e)
        {
            string connstr = WebConfigurationManager.ConnectionStrings["milestone3"].ToString();
            SqlConnection conn = new SqlConnection(connstr);

            string first_name = supervisor_first_name.Text;
            string last_name = supervisor_last_name.Text;
            string email = supervisor_email.Text;
            string password = supervisor_password.Text;

            string faculty = supervisor_faculty.Text;
            


            SqlCommand registerproc = new SqlCommand("supervisorRegister", conn);
            registerproc.CommandType = CommandType.StoredProcedure;
            registerproc.Parameters.Add(new SqlParameter("@first_name ", first_name));
            registerproc.Parameters.Add(new SqlParameter("@last_name", last_name));
            registerproc.Parameters.Add(new SqlParameter("@email", email));
            registerproc.Parameters.Add(new SqlParameter("@password", password));

            registerproc.Parameters.Add(new SqlParameter("@faculty", faculty));


            conn.Open();
            registerproc.ExecuteNonQuery();
            conn.Close();
            Response.Redirect("login.aspx");

        }
    }
}