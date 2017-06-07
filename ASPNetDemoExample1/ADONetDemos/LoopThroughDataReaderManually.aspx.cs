using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using ASPNetDemoExample1.App_Code;

namespace ASPNetDemoExample1.ADONetDemos
{
    public partial class LoopThroughDataReaderManually : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                UserDetails x = new UserDetails();
                SqlDataReader sdr = x.GetListOfAllUsersDataReader();
                showData(sdr);
            }
        }

        private void showData(SqlDataReader sdr)
        {
            bool blHasRows = true;

            while (blHasRows)
            {
                Response.Write("<table border=5 bgColor=aqua>");
                Response.Write("<tr>");
                // column names
                for(int i=0;i<sdr.FieldCount; i++)
                {
                    Response.Write("<td>");
                    Response.Write(sdr.GetName(i));
                    Response.Write("</td>");
                }
                Response.Write("</tr>");

               
                // Printing Records
                while (sdr.Read())
                {
                    Response.Write("<tr>");
                   
                    // Printing each row
                    for (int i = 0; i < sdr.FieldCount; i++)
                    {
                        Response.Write("<td>");
                        Response.Write(sdr.GetValue(i));
                        Response.Write("</td>");
                    }
                    Response.Write("</tr>");
                }
                

                Response.Write("</table>");
                blHasRows = sdr.NextResult(); // the second select statement -> and returns true if we have a table.
            }
        }
    }
}