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
    public partial class update_thesis : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void upsub(object sender, EventArgs e)
        {
            try
            {
                string connstr = WebConfigurationManager.ConnectionStrings["milestone3"].ToString();
                SqlConnection conn = new SqlConnection(connstr);

                int thesis = Int32.Parse(Thesissn.Text);


                SqlCommand loginproc = new SqlCommand("AdminUpdateExtension", conn);
                loginproc.CommandType = CommandType.StoredProcedure;
                loginproc.Parameters.Add(new SqlParameter("@ThesisSerialNo", thesis));
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