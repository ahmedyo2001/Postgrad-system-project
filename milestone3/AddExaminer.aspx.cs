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
    public partial class AddExaminer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void AddEx(object sender, EventArgs e)
        {
            try
            {
                string connstr = WebConfigurationManager.ConnectionStrings["milestone3"].ToString();
                SqlConnection conn = new SqlConnection(connstr);

                int ThesisSerialno =Int16.Parse( ThesisSN.Text);
                int ExaminerID = Int16.Parse(ExID.Text);
                string DefenseDate = Convert.ToString(DefDate.SelectedDate);


                SqlCommand AddExaminerproc = new SqlCommand("AddExaminer", conn);
                AddExaminerproc.CommandType = CommandType.StoredProcedure;
                AddExaminerproc.Parameters.Add(new SqlParameter("@ThesisSerialNo ", ThesisSerialno));
                AddExaminerproc.Parameters.Add(new SqlParameter("@DefenseDate", DefenseDate));
                AddExaminerproc.Parameters.Add(new SqlParameter("@ExaminerID", ExaminerID));

               

                conn.Open();
                AddExaminerproc.ExecuteNonQuery();
                conn.Close();
            }
            catch
            {
                Response.Write("<script>alert('please enter correct data');</script>");
            }
        }
    }
}