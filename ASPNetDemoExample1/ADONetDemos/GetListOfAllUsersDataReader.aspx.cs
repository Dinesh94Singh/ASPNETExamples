using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using ASPNetDemoExample1.App_Code;
using System.Data.SqlClient;

namespace ASPNetDemoExample1.ADONetDemos
{
    public partial class GetListOfAllUsersDataReader : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                UserDetails x = new UserDetails();
                SqlDataReader sdr = x.GetListOfAllUsersDataReader();
                GridView1.DataSource = sdr;
                GridView1.DataBind();
                sdr.Close(); // now the connection from UserDetails is closed 
                sdr.Dispose();
                sdr = null; 
            }
        }

        // need a live connection
        
    }
}