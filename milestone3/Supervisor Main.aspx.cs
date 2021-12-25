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
    public partial class Supervisor_Main : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        //ssss
        protected void ViewStudentClick(object sender, EventArgs e)
        {
            Response.Redirect("Supervisor views students.aspx");
        }
        protected void ViewStudentPublications(object sender, EventArgs e)
        {
            Response.Redirect("ViewStudentPublication.aspx");
        }
        protected void AddDefense(object sender, EventArgs e)
        {
            Response.Redirect("AddDefense.aspx");
        }
        protected void AddExaminer(object sender, EventArgs e)
        {
            Response.Redirect("AddExaminer.aspx");
        }
    }
}