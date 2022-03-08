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
    public partial class Add_Phone_NonGucian : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void add_phone(object sender, EventArgs e)
        {
            try
            {
                string phone = Phone_Number.Text;
                string connstr = WebConfigurationManager.ConnectionStrings["milestone3"].ToString();
                SqlConnection conn = new SqlConnection(connstr);
                SqlCommand loginproc = new SqlCommand("addMobile", conn);
                loginproc.CommandType = CommandType.StoredProcedure;
                int id = Int16.Parse(Session["id"].ToString());
                loginproc.Parameters.Add(new SqlParameter("@ID ", id));
                loginproc.Parameters.Add(new SqlParameter("@mobile_number", phone));



                conn.Open();
                loginproc.ExecuteNonQuery();
                conn.Close();
                Response.Write("<script language='javascript'>window.alert('Phone added successfully');window.location='NonGucian_home.aspx';</script>");
            }
            catch (Exception)
            {
                Response.Write("<script language='javascript'>window.alert('error,try again');</script>");
            }
        }
    }
}