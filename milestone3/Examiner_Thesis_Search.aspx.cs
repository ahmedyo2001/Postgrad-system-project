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
    public partial class Examiner_Thesis_Search : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Search(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Thesis_Title.Text))
            {
                Response.Write("<script>alert('error');</script>");
            }
            else
            {
                try
                {
                    string connstr = WebConfigurationManager.ConnectionStrings["milestone3"].ToString();
                    SqlConnection conn = new SqlConnection(connstr);

                    string title = Thesis_Title.Text;
                    int id = Int16.Parse(Session["id"].ToString());

                    SqlCommand searchproc = new SqlCommand("searchThesis", conn);
                    searchproc.CommandType = CommandType.StoredProcedure;
                    searchproc.Parameters.Add(new SqlParameter("@title ", title));
                    searchproc.Parameters.Add(new SqlParameter("@id ", id));




                    conn.Open();
                    searchproc.ExecuteNonQuery();
                    SqlDataReader reader = searchproc.ExecuteReader();
                    GridView1.DataSource = reader;
                    GridView1.DataBind();
                    conn.Close();


                }
                catch (Exception)
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