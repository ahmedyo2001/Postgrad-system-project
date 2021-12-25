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
    public partial class AddDefenseNonGucian : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void AddNG(object sender, EventArgs e)
        {
            string connstr = WebConfigurationManager.ConnectionStrings["milestone3"].ToString();
            SqlConnection conn = new SqlConnection(connstr);

            string ThesisSerialno = ThesissnNG.Text;
            string DefenseLocation = DefLocNG.Text;
            string DefenseDate = Convert.ToString(DefDateNG.SelectedDate);


            SqlCommand AddDefenseNonGucianproc = new SqlCommand("AddDefenseNonGucian", conn);
            AddDefenseNonGucianproc.CommandType = CommandType.StoredProcedure;
            AddDefenseNonGucianproc.Parameters.Add(new SqlParameter("@ThesisSerialNo ", ThesisSerialno));
            AddDefenseNonGucianproc.Parameters.Add(new SqlParameter("@DefenseDate", DefenseDate));
            AddDefenseNonGucianproc.Parameters.Add(new SqlParameter("@DefenseLocation", DefenseLocation));



            conn.Open();
            AddDefenseNonGucianproc.ExecuteNonQuery();
            conn.Close();

        }
    }
}