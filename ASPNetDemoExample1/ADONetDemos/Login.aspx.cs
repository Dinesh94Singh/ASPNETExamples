using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ASPNetDemoExample1.App_Code;

namespace ASPNetDemoExample1.ADONetDemos
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int Counter = 0;
            UserDetails x = new UserDetails();
            x.UserName = TextBox1.Text;
            x.Password = TextBox2.Text;

            Counter = x.CheckCred();

            if (Counter.Equals(1))
            {
                // Label3.Text = "Successfully Logged";
                // Redirect to Home Page 

                /* Session["Sess_UserName"] = TextBox1.Text;
                Session["Sess_Password"] = TextBox2.Text; */

                MySessionVariables x = new MySessionVariables();
                x.UserName = TextBox1.Text;
                x.Password = TextBox2.Text;
                
                Response.Redirect("Home.aspx");

            }
            else
            {
                Label3.Text = "Sorry Wrong Combination !!";
            }

            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox1.Text = String.Empty;
            TextBox2.Text = String.Empty;
        }
    }
}