using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace milestone3
{
    public partial class login : System.Web.UI.Page
    { 
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Login(object sender , EventArgs e)
        {
            string connstr = WebConfigurationManager.ConnectionStrings["milestone3"].ToString();
            SqlConnection conn = new SqlConnection(connstr);

            string email = login_id.Text;
            string pass = login_password.Text;

            SqlCommand loginproc = new SqlCommand("userLogin",conn);
            loginproc.CommandType = CommandType.StoredProcedure;
            loginproc.Parameters.Add(new SqlParameter("@email ", email ));
            loginproc.Parameters.Add(new SqlParameter("@password", pass));

            SqlParameter success = loginproc.Parameters.Add("@success", SqlDbType.Int);
            SqlParameter type = loginproc.Parameters.Add("@type", SqlDbType.VarChar,20);
            success.Direction = ParameterDirection.Output;
            type.Direction = ParameterDirection.Output;
            
            conn.Open();
            loginproc.ExecuteNonQuery();
            conn.Close();
            string type1 = type.Value.ToString();

            if (success.Value.ToString() == "1")
            {
                
                if (type1 == "Gucian")
                {
                    Response.Redirect("Gucian Main.aspx");
                }
                if (type1 == "NonGucian")
                {
                    Response.Redirect("NonGucian Main.aspx");
                }
                if (type1 == "Admin")
                {
                    Response.Redirect("Admin Main.aspx");
                }
                if (type1 == "Supervisor")
                {
                    Response.Redirect("Supervisor Main.aspx");
                }

                if (type1 == "Examiner")
                {
                    Response.Redirect("Examiner Main.aspx");
                }
                



            }
        }
    }
}