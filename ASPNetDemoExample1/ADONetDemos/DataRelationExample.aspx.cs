using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Web.UI.WebControls;
using ASPNetDemoExample1.App_Code;

namespace ASPNetDemoExample1.ADONetDemos
{
    public partial class DataRelationExample : System.Web.UI.Page
    {
        DataSet dSet = null;
        DataRelation UserContacts = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                UserDetails x = new UserDetails();
                dSet = x.GetListOfAllUsers();

                ViewState["Rel"] = dSet;

                // Like a Join in SQL
                UserContacts = dSet.Relations.Add("UserContacts",
                                    dSet.Tables[0].Columns["UserID"],
                                    dSet.Tables[1].Columns["UserID"]
                                    );
                GridView1.DataSource = dSet;
                GridView2.DataBind();
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow gvr = GridView1.SelectedRow;
            dSet = (DataSet) ViewState["Rel"];

            DataColumn[] dcpk = new DataColumn[1];

            // set primary key
            dcpk[0] = dSet.Tables[0].Columns["UserName"];
            dSet.Tables[0].PrimaryKey = dcpk;

            DataRow drfound;

            // Find the Contact information if any on UserID and load it into drfound where Cells[6] is UserID
            drfound = dSet.Tables[0].Rows.Find(gvr.Cells[6].Text);

            // Get the Child Records for the Found UserID
            DataRow[] childRows = drfound.GetChildRows("UserContacts");

            // Create a Table and Add those Columns
            DataTable FilteredTable = new DataTable();
            DataColumn dCol1 = new DataColumn("UserID");
            DataColumn dCol2 = new DataColumn("ContactID");
            DataColumn dCol3 = new DataColumn("PhoneNumber");
            DataColumn dCol4 = new DataColumn("LandLine");
            DataColumn dCol5 = new DataColumn("Fax");

            FilteredTable.Columns.Add(dCol1);
            FilteredTable.Columns.Add(dCol2);
            FilteredTable.Columns.Add(dCol3);
            FilteredTable.Columns.Add(dCol4);
            FilteredTable.Columns.Add(dCol5);

           
            // Add data (rows) into those columns
            foreach(DataRow dr in childRows)
            {
                FilteredTable.ImportRow(dr);
            }

            GridView2.DataSource = FilteredTable;
            GridView2.DataBind();

        }
    }
}