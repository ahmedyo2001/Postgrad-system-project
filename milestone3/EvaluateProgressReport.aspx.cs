using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace milestone3
{
    public partial class EvaluateProgressReport : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Evaluate(object sender, EventArgs e)
        {
            try
            {
                string connstr = WebConfigurationManager.ConnectionStrings["milestone3"].ToString();
                SqlConnection conn = new SqlConnection(connstr);

                string ThesisSerialno = ThesisSN.Text;
                string ProgressReportNumber = ProgressReportNo.Text;
                string Evaluate = Evaluation.Text;

                int id = Int16.Parse(Session["id"].ToString());
                SqlCommand EvaluateProgressReportproc = new SqlCommand("EvaluateProgressReport", conn);
                EvaluateProgressReportproc.CommandType = CommandType.StoredProcedure;
                EvaluateProgressReportproc.Parameters.Add(new SqlParameter("@supervisorID ", id));
                EvaluateProgressReportproc.Parameters.Add(new SqlParameter("@ThesisSerialNo ", ThesisSerialno));
                EvaluateProgressReportproc.Parameters.Add(new SqlParameter("@progressReportNo", ProgressReportNumber));
                EvaluateProgressReportproc.Parameters.Add(new SqlParameter("@evaluation", Evaluate));



                conn.Open();
                EvaluateProgressReportproc.ExecuteNonQuery();
                conn.Close();
            }
            catch
            {
                Response.Write("<script>alert('please enter correct data');</script>");
            }
        }
    }
}