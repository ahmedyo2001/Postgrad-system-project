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
    public partial class Student_Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void StudentRegister(object sender, EventArgs e)
        {
            string connstr = WebConfigurationManager.ConnectionStrings["milestone3"].ToString();
            SqlConnection conn = new SqlConnection(connstr);

            string  first_name = student_first_name.Text;
            string last_name = student_last_name.Text;
            string email = student_email.Text;
            string password = student_password.Text;
            string address = student_address.Text;
            string faculty = student_faculty.Text;
            int gucian =Int16.Parse(Gucian.SelectedItem.Value.ToString());


            SqlCommand loginproc = new SqlCommand("userLogin", conn);
            loginproc.CommandType = CommandType.StoredProcedure;
            loginproc.Parameters.Add(new SqlParameter("@id ", first_name));
            loginproc.Parameters.Add(new SqlParameter("@password", last_name));

            SqlParameter success = loginproc.Parameters.Add("@success", SqlDbType.Int);
            success.Direction = ParameterDirection.Output;
            conn.Open();
            loginproc.ExecuteNonQuery();
            conn.Close();

            if (success.Value.ToString() == "1")
            {
                Response.Write("hello");
            }
        }
    }
}