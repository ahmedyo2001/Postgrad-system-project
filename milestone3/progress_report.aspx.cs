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
    public partial class progress_report_Gucian : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void add_progress_report(object sender, EventArgs e)
        {
            try
            {
                string connstr = WebConfigurationManager.ConnectionStrings["milestone3"].ToString();
                SqlConnection conn = new SqlConnection(connstr);
                SqlCommand addprog = new SqlCommand("AddProgressReport", conn);
                addprog.CommandType = CommandType.StoredProcedure;
                int serialNo = Int16.Parse(thesis_serial_add.Text);
                int progressNo = Int16.Parse(progress_no.Text);
                string prog_date = Convert.ToString(progDate.SelectedDate);
                int id = Int16.Parse(Session["id"].ToString());
                addprog.Parameters.Add(new SqlParameter("@thesisSerialNo", serialNo));
                addprog.Parameters.Add(new SqlParameter("@progressReportDate", prog_date));
                addprog.Parameters.Add(new SqlParameter("@studentID", id));
                addprog.Parameters.Add(new SqlParameter("@progressReportNo", progressNo));

                conn.Open();
                addprog.ExecuteNonQuery();
                conn.Close();
                Response.Write("<script>alert('progress report added successfully for given thesis if given thesis exists');</script>");
            }
            catch(Exception)
            {
                Response.Write("<script>alert('error,try again');</script>");
            }


        }
        protected void fill_progress_report(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(thesis_serial_fill.Text) || String.IsNullOrEmpty(progress_report_number2.Text) || String.IsNullOrEmpty(state1.Text) || String.IsNullOrEmpty(description1.Text))
            {
                Response.Write("<script>alert('one of the fields is empty');</script>");
            }
            else
            {
                string connstr = WebConfigurationManager.ConnectionStrings["milestone3"].ToString();
                SqlConnection conn = new SqlConnection(connstr);
                SqlCommand fillprog = new SqlCommand("FillProgressReport", conn);
                fillprog.CommandType = CommandType.StoredProcedure;
                int serialNo = Int16.Parse(thesis_serial_fill.Text);
                int progressNo = Int16.Parse(progress_report_number2.Text);
                int state = Int16.Parse(state1.Text);
                string description = description1.Text;
                int id = Int16.Parse(Session["id"].ToString());
                fillprog.Parameters.Add(new SqlParameter("@thesisSerialNo", serialNo));
                fillprog.Parameters.Add(new SqlParameter("@state", state));
                fillprog.Parameters.Add(new SqlParameter("@studentID", id));
                fillprog.Parameters.Add(new SqlParameter("@description", description));
                fillprog.Parameters.Add(new SqlParameter("@progressReportNo", progressNo));

                conn.Open();
                fillprog.ExecuteNonQuery();
                conn.Close();
                Response.Write("<script>alert('progress report filled successfully');</script>");
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