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
    public partial class Examiner_Responsibilities : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {


            try
            {
                string connstr = WebConfigurationManager.ConnectionStrings["milestone3"].ToString();
                SqlConnection conn = new SqlConnection(connstr);
                SqlCommand ExaminerRespproc = new SqlCommand("ViewExaminerResponsibilities", conn);
                ExaminerRespproc.CommandType = CommandType.StoredProcedure;
                int id = Int16.Parse(Session["id"].ToString());
                ExaminerRespproc.Parameters.Add(new SqlParameter("@ExaminerID ", id));

                conn.Open();
                SqlDataReader reader = ExaminerRespproc.ExecuteReader();
                GridView1.DataSource = reader;
                GridView1.DataBind();
                conn.Close();
            }
            catch (Exception)
            {
                Response.Write("<script>alert('error');</script>");
            }
        }

        protected void Back(object sender, EventArgs e)
        {
            Response.Redirect("Examiner_Main.aspx");
        }
    }
}