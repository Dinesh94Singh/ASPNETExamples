using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ASPNetDemoExample1.App_Code;
using System.Data;
namespace ASPNetDemoExample1.ADONetDemos
{
    public partial class GetListOfAllUsers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                UserDetails x = new UserDetails();
                DataSet dSet = x.GetListOfAllUsers();

                // writing to XML 

                dSet.WriteXml(@"C:\Developer\DsetXMLFile.xml");
                GridView1.DataSource = dSet;
                GridView1.DataBind();

                BulletedList1.DataSource = dSet;
                BulletedList1.DataTextField = "UserName";
                BulletedList1.DataValueField = "UserName";
                BulletedList1.DataBind(); // Records not coming since it can only show only one column

                CheckBoxList1.DataSource = dSet;
                CheckBoxList1.DataTextField = "UserName";
                CheckBoxList1.DataValueField = "UserName";
                CheckBoxList1.DataBind();

                DropDownList1.DataSource = dSet;
                DropDownList1.DataTextField = "UserName";
                DropDownList1.DataValueField = "UserName";
                DropDownList1.DataBind();

                RadioButtonList1.DataSource = dSet;
                RadioButtonList1.DataTextField = "UserName";
                RadioButtonList1.DataValueField = "UserName";
                RadioButtonList1.DataBind();

                ListBox1.DataSource = dSet;
                ListBox1.DataTextField = "UserName";
                ListBox1.DataValueField = "UserName";
                ListBox1.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet dSet = new DataSet();
            dSet.ReadXml(@"C:\Developer\DSetXMLFile.xml");
            GridView2.DataSource = dSet;
            GridView2.DataBind();
        }
    }
}