using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace milestone3
{
    public partial class CancelThesis : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Cancel(object sender, EventArgs e)
        {
            try
            {
                string connstr = WebConfigurationManager.ConnectionStrings["milestone3"].ToString();
                SqlConnection conn = new SqlConnection(connstr);

                string ThesisSerialno = ThesisSN.Text;

                SqlCommand CancelThesisproc = new SqlCommand("CancelThesis", conn);
                CancelThesisproc.CommandType = CommandType.StoredProcedure;
                CancelThesisproc.Parameters.Add(new SqlParameter("@ThesisSerialNo ", ThesisSerialno));

                conn.Open();
                CancelThesisproc.ExecuteNonQuery();
                conn.Close();
            }
            catch
            {
                Response.Write("<script>alert('please enter correct data');</script>");
            }
        }
    }
}