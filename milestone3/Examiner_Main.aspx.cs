using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace milestone3
{
    public partial class Examiner_Main : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void ViewExaminerInfo(object sender, EventArgs e)
        {
            Response.Redirect("Examiner_Personal_Information.aspx");
        }
        protected void ViewExaminerResponsibilities(object sender, EventArgs e)
        {
            Response.Redirect("Examiner_Responsibilities.aspx");
        }
        protected void AddComments(object sender, EventArgs e)
        {
            Response.Redirect("Examiner_Comments.aspx");
        }
        protected void AddGrade(object sender, EventArgs e)
        {
            Response.Redirect("Examiner_Grade.aspx");
        }
        protected void SearchThesis(object sender, EventArgs e)
        {
            Response.Redirect("Examiner_Thesis_Search.aspx");
        }
    }
}