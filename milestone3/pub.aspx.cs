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
    public partial class Gucian_pub : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void addPub(object sender, EventArgs e)
        {





            try
            {

                string connstr = WebConfigurationManager.ConnectionStrings["milestone3"].ToString();
                SqlConnection conn = new SqlConnection(connstr);
                string title = title1.Text;
                string host = host1.Text;
                string pubDate = Convert.ToString(pubDate1.SelectedDate);
                string place = place1.Text;
                SqlCommand addPub = new SqlCommand("addPublication", conn);
                addPub.CommandType = CommandType.StoredProcedure;
                if (Accepted1.SelectedItem != null)
                {
                    int accepted = Int16.Parse(Accepted1.SelectedItem.Value.ToString());
                    addPub.Parameters.Add(new SqlParameter("@accepted", accepted));
                }
                else
                {
                    addPub.Parameters.Add(new SqlParameter("@accepted", null));
                }
             

                addPub.Parameters.Add(new SqlParameter("@title", title));
                addPub.Parameters.Add(new SqlParameter("@host", host));
                addPub.Parameters.Add(new SqlParameter("@pubDate", pubDate));
                addPub.Parameters.Add(new SqlParameter("@place", place));
           

                SqlParameter id = addPub.Parameters.Add("@id", SqlDbType.Int);

                id.Direction = ParameterDirection.Output;

                conn.Open();
                addPub.ExecuteNonQuery();
                conn.Close();
                Session["pubID"] = Int16.Parse(id.Value.ToString());
                Response.Write("<script language='javascript'>window.alert('Publication added successfully');window.location='linkpub.aspx';</script>");
            }
            catch (Exception)
            {
                Response.Write("<script>alert('error ,try again');</script>");
            }
             
        }

      
        protected void back(object sender, EventArgs e)
        {
            string connstr = WebConfigurationManager.ConnectionStrings["milestone3"].ToString();
            SqlConnection conn = new SqlConnection(connstr);
      
            string type = (Session["type"].ToString());

  

            if (type =="Gucian")
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