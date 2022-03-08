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
    public partial class Examiner_Personal_Information : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Confirm(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Examiner_Name.Text) || string.IsNullOrEmpty(Examiner_Field_Of_Work.Text))
            {
                Response.Write("<script>alert('error');</script>");
            }
            else
            {
                try
                {
                    string connstr = WebConfigurationManager.ConnectionStrings["milestone3"].ToString();
                    SqlConnection conn = new SqlConnection(connstr);

                    string name = Examiner_Name.Text;
                    string field_of_work = Examiner_Field_Of_Work.Text;
                    int id = Int16.Parse(Session["id"].ToString());

                    SqlCommand editproc = new SqlCommand("updateExaminer", conn);
                    editproc.CommandType = CommandType.StoredProcedure;
                    editproc.Parameters.Add(new SqlParameter("@id ", id));
                    editproc.Parameters.Add(new SqlParameter("@name ", name));
                    editproc.Parameters.Add(new SqlParameter("@fieldOfWork", field_of_work));



                    conn.Open();
                    editproc.ExecuteNonQuery();
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