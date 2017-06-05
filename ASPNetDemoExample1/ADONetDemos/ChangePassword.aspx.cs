using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ASPNetDemoExample1.App_Code;

namespace ASPNetDemoExample1.ADONetDemos
{
    public partial class ChangePassword1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            MySessionVariables x = new MySessionVariables();
            string UserName = x.UserName;
            string Password = x.Password;
            string oldPassword = TextBox1.Text;
            if (Password.Equals(oldPassword))
            {
                string NewPassword = TextBox2.Text;
                UserDetails x = new UserDetails();
                x.UserName = UserName;
                x.Password = NewPassword;
                int Counter = x.ChangePass();

                if (Counter.Equals(1))
                {
                    // Password Changed - Logout from all other users and login back
                    Session.Abandon();
                    Response.Redirect("Login.aspx");
                }
                else
                {
                    Label3.Text = "<H1> Your Password Couldnt be Updated </h1>";
                }
            }
            else
            {
                Label3.Text = "Incorrect Old Password !!";
            }

        }
    }
}