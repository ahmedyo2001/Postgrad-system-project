using System;
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
            if (String.IsNullOrEmpty(login_id.Text) || String.IsNullOrEmpty(login_password.Text))
            {
                Response.Write("<script>alert('email or pass are empty');</script>");
            }
            else
            {
                try
                {

                    string connstr = WebConfigurationManager.ConnectionStrings["milestone3"].ToString();
                    SqlConnection conn = new SqlConnection(connstr);

                    string email = login_id.Text;
                    string pass = login_password.Text;

                    SqlCommand loginproc = new SqlCommand("userLogin", conn);
                    loginproc.CommandType = CommandType.StoredProcedure;
                    loginproc.Parameters.Add(new SqlParameter("@email ", email));
                    loginproc.Parameters.Add(new SqlParameter("@password", pass));

                    SqlParameter success = loginproc.Parameters.Add("@success", SqlDbType.Int);
                    SqlParameter id = loginproc.Parameters.Add("@id", SqlDbType.Int);
                    SqlParameter type = loginproc.Parameters.Add("@type", SqlDbType.VarChar, 20);
                    success.Direction = ParameterDirection.Output;
                    type.Direction = ParameterDirection.Output;
                    id.Direction = ParameterDirection.Output;

                    conn.Open();
                    loginproc.ExecuteNonQuery();
                    conn.Close();
                    string type1 = type.Value.ToString();
                    Session["id"] = Int16.Parse(id.Value.ToString());
                    Session["type"] = (type.Value.ToString());

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
                            Response.Redirect("Admin_Main.aspx");
                        }
                        if (type1 == "Supervisor")
                        {
                            Response.Redirect("Sup_home.aspx");
                        }

                        if (type1 == "Examiner")
                        {
                            Response.Redirect("Examiner_Main.aspx");
                        }




                    }
                }
                catch (Exception )
                {
                    Response.Write("<script>alert('email or pass are incorrect');</script>");
                }
            }
        }
    }
}