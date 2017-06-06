using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Web.UI.WebControls;

namespace ASPNetDemoExample1.ADONetDemos
{
    public partial class FillDataSetManually : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ShowData();
            }
        }

        private void ShowData()
        {
            DataSet dSet = new DataSet();
            DataTable dTable = new DataTable();
            DataColumn dCol1 = new DataColumn("ECode");
            DataColumn dCol2 = new DataColumn("EName");
            DataColumn dCol3 = new DataColumn("Salary");

            DataRow dRow;

            dTable.Columns.Add(dCol1);
            dTable.Columns.Add(dCol2);
            dTable.Columns.Add(dCol3);

            for(int i = 65; i <= 90; i++)
            {
                dRow = dTable.NewRow();
                dRow[0] = i.ToString();
                dRow[1] = ((char)i).ToString();
                dRow["Salary"] = i * 10000;

                dTable.Rows.Add(dRow);
            }
            GridView1.DataSource = dTable;
            GridView1.DataBind();
        }
    }
}