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
    public partial class Admin_Main : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connstr = WebConfigurationManager.ConnectionStrings["milestone3"].ToString();
            SqlConnection conn = new SqlConnection(connstr);
            SqlCommand loginproc = new SqlCommand("AdminViewOnGoingTheses", conn);
            loginproc.CommandType = CommandType.StoredProcedure;
            SqlParameter id = loginproc.Parameters.Add("@thesesCount", SqlDbType.Int);
            id.Direction = ParameterDirection.Output;
            conn.Open();
            loginproc.ExecuteNonQuery();
            conn.Close();
            string type1 = id.Value.ToString();
            Label3.Text = type1;
        }

        protected void UpdateextPage(object sender, EventArgs e)
        {
            Response.Redirect("update_thesis.aspx");
        }

        protected void ListSup(object sender, EventArgs e)
        {
            Response.Redirect("List_all_Supervisors.aspx");
        }

        protected void List_All_Theses_Click(object sender, EventArgs e)
        {
            Response.Redirect("List_all_Theses.aspx");
        }

        protected void IssuePay(object sender, EventArgs e)
        {
            Response.Redirect("Issue_Thesis_Payment.aspx");
        }

        protected void IssueInstall(object sender, EventArgs e)
        {
            Response.Redirect("Issue_Installments.aspx");
        }
    }
}