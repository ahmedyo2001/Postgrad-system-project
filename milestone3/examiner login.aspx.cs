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
    public partial class examiner_login : System.Web.UI.Page
    {
        protected void ExaminerRegister(object sender, EventArgs e)
        {
            string connstr = WebConfigurationManager.ConnectionStrings["milestone3"].ToString();
            SqlConnection conn = new SqlConnection(connstr);

            string name = examiner_name.Text;
            string field_of_work = examiner_field_of_work.Text;
            string email = examiner_email.Text;
            string password = examiner_password.Text;
            int national = Int16.Parse(isNational.SelectedItem.Value.ToString());

            SqlCommand registerproc = new SqlCommand("examinerRegister", conn);
            registerproc.CommandType = CommandType.StoredProcedure;
            registerproc.Parameters.Add(new SqlParameter("@ExaminerName ", name));
            registerproc.Parameters.Add(new SqlParameter("@fieldOfWork", field_of_work));
            registerproc.Parameters.Add(new SqlParameter("@email", email));
            registerproc.Parameters.Add(new SqlParameter("@Password", password));
            registerproc.Parameters.Add(new SqlParameter("@National", national));

            conn.Open();
            registerproc.ExecuteNonQuery();
            conn.Close();
            Response.Redirect("login.aspx");

        }
    }
}