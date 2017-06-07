using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using ASPNetDemoExample1.App_Code;
using System.Text;
using System.Data.SqlClient;

namespace ASPNetDemoExample1.ADONetDemos
{
    public partial class BulkInsertPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                DataSet dSet = new DataSet();
                // create a table
                DataTable dTable = new DataTable();
                //create 4 columns for the table
                DataColumn dCol1 = new DataColumn("Name");
                DataColumn dCol2 = new DataColumn("Position");
                DataColumn dCol3 = new DataColumn("City");
                DataColumn dCol4 = new DataColumn("State");
                // Add the Columns to the Table
                dTable.Columns.Add(dCol1);
                dTable.Columns.Add(dCol2);
                dTable.Columns.Add(dCol3);
                dTable.Columns.Add(dCol4);

                DataRow dRow;
                // for 4 rows add empty string since without it, its won't display in the GridView
                for (int i = 1; i <= 3; i++)
                {
                    dRow = dTable.NewRow();
                    dRow[0] = string.Empty;
                    dRow[1] = string.Empty;
                    dRow[2] = string.Empty;
                    dRow[3] = string.Empty;
                }
                dSet.Tables.Add(dTable);

                GridView1.DataSource = dSet;
                GridView1.DataBind();

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            
            /* 4 columns - Name, Position, City, State
             * <root>
             * <row Name=Dinesh Position=.NetDeveloper City=St.Louis State=Missouri />
             * <row Name=TonyEdwards Position=.NetManager City=St.Louis State=Missouri />
             * </root>
            */
            sb.Append("<root>");
            // The above 4 Rows which mentioned as Empty, Get the details of those when clicked
            for(int i = 0; i < GridView1.Rows.Count; i++)
            {
                TextBox txtName = GridView1.Rows[i].FindControl("txtName") as TextBox;
                TextBox txtPosition = GridView1.Rows[i].FindControl("txtPosition") as TextBox;
                TextBox txtCity = GridView1.Rows[i].FindControl("txtCity") as TextBox;
                TextBox txtState = GridView1.Rows[i].FindControl("txtState") as TextBox;

                if(txtName.Text.Length != 0)
                {
                    sb.Append("<row Name='" + txtName.Text.Trim() + "' Position='" + txtPosition.Text.Trim() +
                        "City='" + txtCity.Text.Trim() + "' State='" + txtState.Text.Trim() + "'/>");
                }
            }
            sb.Append("</root>");

            // Instead of defining the USP_InsertCustomer call from the UserDetails, we are directly doing it here.
            string conStr = "data source=.;initial catalog=asptraining;integrated security=true";
            SqlConnection con = new SqlConnection(conStr);
            SqlCommand cmd = new SqlCommand("USP_InsertCustomer"); //InsertCustomer is a Procedure Name
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@XMLCustomer", sb.ToString()); // procedure - One Parameter in InsertCustomer procedure 

            try
            {
                using (con) // to automatically close and dispose
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
                Label1.Text = "Record(s) inserted successfully";
                Label1.ForeColor = System.Drawing.Color.Green;
            }catch(Exception ex)
            {
                Label1.Text = ex.GetBaseException().ToString();
                Label1.ForeColor = System.Drawing.Color.Red;
            }

        }
    }
}