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
    public partial class linkpub : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void linkPub(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(serialNo.Text))
            {
                Response.Write("<script>alert('serial number is empty');</script>");
            }
            else
            {

                try
                {


                    string connstr = WebConfigurationManager.ConnectionStrings["milestone3"].ToString();
                    SqlConnection conn = new SqlConnection(connstr);
                    int serialNumber = Int16.Parse(serialNo.Text);
                    int pubID = Int16.Parse(Session["pubID"].ToString());
                    SqlCommand linkPub = new SqlCommand("linkPubThesis", conn);
                    linkPub.CommandType = CommandType.StoredProcedure;

                    linkPub.Parameters.Add(new SqlParameter("@PubID", pubID));

                    linkPub.Parameters.Add(new SqlParameter("@thesisSerialNo", serialNumber));


                    conn.Open();
                    linkPub.ExecuteNonQuery();
                    conn.Close();
                    Response.Write("<script>alert('publication linked to thesis successfully');</script>");

                }
                catch (Exception)
                {
                    Response.Write("<script>alert('thesis doesnt exist');</script>");
                }

            }



        }
        protected void back(object sender, EventArgs e)
        {
            string connstr = WebConfigurationManager.ConnectionStrings["milestone3"].ToString();
            SqlConnection conn = new SqlConnection(connstr);

            string type = (Session["type"].ToString());



            if (type == "Gucian")
            {
                Response.Redirect("Gucian_home.aspx");
            }
            else
                if (type == "NonGucian")
            {
                Response.Redirect("NonGucian_home.aspx");
            }

        }
    }
}