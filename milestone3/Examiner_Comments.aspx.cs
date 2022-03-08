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
    public partial class Examiner_Comments : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Confirm(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Thesis_NO.Text) || String.IsNullOrEmpty(Defense_Date.Text) || String.IsNullOrEmpty(Comments.Text))
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
                    string Comment = Comments.Text;

                    SqlCommand commentproc = new SqlCommand("AddCommentsGrade", conn);
                    commentproc.CommandType = CommandType.StoredProcedure;
                    commentproc.Parameters.Add(new SqlParameter("@ThesisSerialNo", serial_number));
                    commentproc.Parameters.Add(new SqlParameter("@DefenseDate ", Defense_Date_));
                    commentproc.Parameters.Add(new SqlParameter("@comments", Comment));



                    conn.Open();
                    commentproc.ExecuteNonQuery();
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