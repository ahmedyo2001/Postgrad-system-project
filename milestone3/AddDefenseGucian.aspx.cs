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
    public partial class AddDefenseGucian : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          

        }

        protected void Add(object sender, EventArgs e)
        {
            string connstr = WebConfigurationManager.ConnectionStrings["milestone3"].ToString();
            SqlConnection conn = new SqlConnection(connstr);

            string ThesisSerialno = Thesissn.Text;
            string DefenseLocation = DefLoc.Text;
            string DefenseDate = Convert.ToString(DefDate.SelectedDate);


            SqlCommand AddDefenseGucianproc = new SqlCommand("AddDefenseGucian", conn);
            AddDefenseGucianproc.CommandType = CommandType.StoredProcedure;
            AddDefenseGucianproc.Parameters.Add(new SqlParameter("@ThesisSerialNo ", ThesisSerialno));
            AddDefenseGucianproc.Parameters.Add(new SqlParameter("@DefenseDate", DefenseDate));
            AddDefenseGucianproc.Parameters.Add(new SqlParameter("@DefenseLocation", DefenseLocation));
            //fddddd


            conn.Open();
            AddDefenseGucianproc.ExecuteNonQuery();
            conn.Close();

        }
    }
}