using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace ASPNetDemoExample1.ADONetDemos
{
    public partial class MARS : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                GetCustomers();
            }
        }

        public void GetCustomers()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=.;Initial Catalog=ASPNetTraining; Integrated Security=true;MultipleActiveResultsets=true");
            connection.Open();

            SqlCommand command1 = new SqlCommand();
            command1.Connection = connection;
            command1.CommandType = CommandType.Text;
            command1.CommandText = "select * from UserDetails order by UserID";
            SqlDataReader reader1 = command1.ExecuteReader(CommandBehavior.CloseConnection);

            while (reader1.Read())
            {
                Response.Write(reader1["UserID"] + " ");

                SqlCommand command2 = new SqlCommand();
                command2.Connection = connection;
                command2.CommandText = "select * from Contacts where UserID=" + reader1["UserID"];
                SqlDataReader reader2 = command2.ExecuteReader(CommandBehavior.CloseConnection);

                while (reader2.Read())
                {
                    Response.Write("<br>" + reader2["Fax"] + "," + reader2["PhoneNumber"] + "," + reader2["LandLine"]);
                                                                                                                                                   
                }
            }
        }
    }
}