using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Windows;
using EO.WebBrowser.DOM;

namespace milestone3
{
    public partial class Issue_Installments : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {


                Int32 id = Int32.Parse(Payment.Text);
                String am = sdate.Text;

                string connstr = WebConfigurationManager.ConnectionStrings["milestone3"].ToString();
                SqlConnection conn = new SqlConnection(connstr);
                SqlCommand loginproc = new SqlCommand("AdminIssueInstallPayment", conn);
                loginproc.CommandType = CommandType.StoredProcedure;
                loginproc.Parameters.Add(new SqlParameter("@paymentID", id));
                loginproc.Parameters.Add(new SqlParameter("@InstallStartDate", am));

                conn.Open();
                loginproc.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception)
            {
                Response.Write("<script>alert('error');</script>");
            }
        }
        protected void Back_Click(object sender, EventArgs e)
        {
            Response.Redirect("admin_main.aspx");
        }
    }
}