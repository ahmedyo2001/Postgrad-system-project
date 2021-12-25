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
            string connstr = WebConfigurationManager.ConnectionStrings["milestone3"].ToString();
            SqlConnection conn = new SqlConnection(connstr);
            string thesisSn = ThesisSN.Text;
            string defenseDate = Convert.ToString(DefDate.SelectedDate);
            string examinerName = ExaminerName.Text;
            string isNational = CheckBox1.Text;
            string fieldOfWork = FieldOfWork.Text;

            SqlCommand AddExaminerproc = new SqlCommand("AddExaminer", conn);
            AddExaminerproc.CommandType = CommandType.StoredProcedure;
            AddExaminerproc.Parameters.Add(new SqlParameter("@ThesisSerialNo ", thesisSn));
            AddExaminerproc.Parameters.Add(new SqlParameter("@DefenseDate", defenseDate));
            AddExaminerproc.Parameters.Add(new SqlParameter("@ExaminerName", examinerName));
            AddExaminerproc.Parameters.Add(new SqlParameter("@National", isNational));
            AddExaminerproc.Parameters.Add(new SqlParameter("@fieldOfWork", fieldOfWork));



            conn.Open();
            AddExaminerproc.ExecuteNonQuery();
            conn.Close();
        }
    }
}