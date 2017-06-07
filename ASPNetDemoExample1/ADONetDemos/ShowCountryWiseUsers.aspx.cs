using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using ASPNetDemoExample1.App_Code;
namespace ASPNetDemoExample1.ADONetDemos
{
    public partial class ShowCountryWiseUsers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                UserDetails x = new UserDetails();
                DataSet dSet = x.GetListOfAllCountries();
                DropDownList1.DataSource = dSet;
                DropDownList1.DataTextField = "Country";
                DropDownList1.DataValueField = "Country";
                DropDownList1.DataBind();
                ListItem li = new ListItem("All Users", "All Users");
                DropDownList1.Items.Insert(0, li);
                DataSet dSet2 = x.GetListOfAllUsers();
                ViewState["VS_DataSet"] = dSet2;
                GridView1.DataSource = dSet2;
                GridView1.DataBind();
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = DropDownList1.SelectedItem.Text;

            UserDetails x = new UserDetails();
            x.Country = str;
            DataSet dSet = null;
            // Problem here is that, we are using the same dataSet and calculating again, but we already hv the values from !Page.IsPostBack
            // So we are creating a DataView
            /* if (str.ToUpper() != "ALLUSERS")
                dSet = x.GetCountryWiseUsers();
            else
                dSet = x.GetListOfAllUsers(); */
            dSet = (DataSet)ViewState["VS_DataSet"];
            DataView dv = dSet.Tables[0].DefaultView;

            if (str.ToUpper() != "ALLUSERS")
                dv.RowFilter = "Country='" + str + "'";
            
            GridView1.DataSource = dv;
            GridView1.DataBind();
        }
    }
}