using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ASPNetDemoExample1.App_Code;

namespace ASPNetDemoExample1.ADONetDemos
{
    public partial class SignUp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            UserDetails x = new UserDetails();
            int Counter = 0;

            // UI Controls - > Class Properties - > Parameters - > Table Columns 
            
            try
            {
                x.UserName = TextBox1.Text;
                x.Password = TextBox2.Text;
                x.Country = DropDownList1.SelectedItem.Text;
                x.Email = TextBox3.Text;

                Counter = x.CreateUser();

                if (Counter.Equals(1))
                {
                    Label5.Text = "SignUp Successfull !!";
                }

            }catch(Exception ex)
            {
                Label5.Text = ex.Message;
            }
        }
    }
}