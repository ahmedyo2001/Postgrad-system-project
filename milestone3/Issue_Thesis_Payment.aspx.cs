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
    public partial class Issue_Thesis_Payment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Issue_Payment(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Thesis.Text) || String.IsNullOrEmpty(Amount.Text) ||
                String.IsNullOrEmpty(Inst.Text) || String.IsNullOrEmpty(fund.Text))
            {
                Response.Write("<script>alert('please enter all required data');</script>");
            }
            else
            {

                try
                {


                    Int32 id = Int32.Parse(Thesis.Text);
                    Double am = Double.Parse(Amount.Text);
                    Int32 install = Int16.Parse(Inst.Text);
                    Double fund1 = Double.Parse(fund.Text);
                    string connstr = WebConfigurationManager.ConnectionStrings["milestone3"].ToString();
                    SqlConnection conn = new SqlConnection(connstr);
                    SqlCommand loginproc = new SqlCommand("AdminIssueThesisPayment", conn);
                    loginproc.CommandType = CommandType.StoredProcedure;
                    loginproc.Parameters.Add(new SqlParameter("@ThesisSerialNo", id));
                    loginproc.Parameters.Add(new SqlParameter("@amount", am));
                    loginproc.Parameters.Add(new SqlParameter("@noOfInstallments", install));
                    loginproc.Parameters.Add(new SqlParameter("@fundPercentage", fund1));
                    conn.Open();
                    loginproc.ExecuteNonQuery();
                    conn.Close();
                }
                catch (Exception)
                {

                    Response.Write("<script>alert('error');</script>");
                }
            }

        }

        protected void Back_Click(object sender, EventArgs e)
        {
            Response.Redirect("admin_main.aspx");
        }
    }
}
