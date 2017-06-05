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
    public partial class ChangeProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                UserDetails x = new UserDetails();
                MySessionVariables sess = new MySessionVariables();
                x.UserName = sess.UserName;

                DataSet dSet = x.GetUserInfo();
                TextBox1.Text = sess.UserName;
                TextBox2.Text = dSet.Tables[0].Rows[0]["Password"].ToString();

                string Country = dSet.Tables[0].Rows[0]["Country"].ToString();
                ListItem li = DropDownList1.Items.FindByText(Country);
                int index = DropDownList1.Items.IndexOf(li);
                DropDownList1.SelectedIndex = index;

                TextBox3.Text = dSet.Tables[0].Rows[0]["Email"].ToString();

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            UserDetails x = new UserDetails();
            MySessionVariables sess = new MySessionVariables();
            x.UserName = sess.UserName;
            x.Password = TextBox2.Text;
            x.Country = DropDownList1.SelectedItem.Text;
            x.Email = TextBox3.Text;

            int Counter = x.UpdateUser();

            if (Counter.Equals(1))
            {
                Label5.Text = "Updated Successfully";
                sess.Abandon();
                Response.Redirect("Login");
            }
            else
            {
                Label5.Text = "There seems to be a Problem !!";
            }
        }
    }
}