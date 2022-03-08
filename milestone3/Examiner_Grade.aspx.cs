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
    public partial class Examiner_Grade : System.Web.UI.Page
    {
        protected void Confirm(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Thesis_NO.Text) || String.IsNullOrEmpty(Defense_Date.Text) || String.IsNullOrEmpty(Grades.Text))
            {
                Response.Write("<script>alert('error');</script>");
            }
            else
            {
                try
                {
                    string connstr = WebConfigurationManager.ConnectionStrings["milestone3"].ToString();
                    SqlConnection conn = new SqlConnection(connstr);

                    string serial_number = Thesis_NO.Text;
                    string Defense_Date_ = Defense_Date.Text;
                    string Grade = Grades.Text;

                    SqlCommand gradeproc = new SqlCommand("AddDefenseGrade", conn);
                    gradeproc.CommandType = CommandType.StoredProcedure;
                    gradeproc.Parameters.Add(new SqlParameter("@ThesisSerialNo", serial_number));
                    gradeproc.Parameters.Add(new SqlParameter("@DefenseDate ", Defense_Date_));
                    gradeproc.Parameters.Add(new SqlParameter("@grade", Grade));



                    conn.Open();
                    gradeproc.ExecuteNonQuery();
                    conn.Close();
                }

                catch
                {
                    Response.Write("<script>alert('error');</script>");
                }
            }
        }
        protected void Back(object sender, EventArgs e)
        {
            Response.Redirect("Examiner_Main.aspx");
        }
    }
}