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
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // int Counter = 0;
            UserDetails x = new UserDetails();
            x.UserName = TextBox1.Text;
            x.Password = TextBox2.Text;

            /* Counter = x.CheckCred(); 

            if (Counter.Equals(1))
            {
                // Label3.Text = "Successfully Logged";
                // Redirect to Home Page 

               Session["Sess_UserName"] = TextBox1.Text;
                Session["Sess_Password"] = TextBox2.Text;

                MySessionVariables x = new MySessionVariables();
                x.UserName = TextBox1.Text;
                x.Password = TextBox2.Text;
                
                Response.Redirect("Home.aspx");

            }
            else
            {
                Label3.Text = "Sorry Wrong Combination !!";
            } */

            DataSet dSet = x.CheckCred();

            int Status = Convert.ToInt32(dSet.Tables[0].Rows[0]["Status"].ToString()); // 1 success , 0 failed, -1 username failed, -3 locked - Check Procedure
            switch (Status)
            {
                case 1:
                    MySessionVariables x = new MySessionVariables();
                    x.UserName = TextBox1.Text;
                    x.Password = TextBox2.Text;
                    Response.Redirect("Home.aspx");
                    break;
                case -1: // Invalid User
                    Label3.Text = "<H1> No such User Exist !!</H1>";
                    break;
                case -2: // Inactive User
                    Label3.Text = "<H1> You have unsubscribed </H1>";
                    break;
                case -3: // Locked 
                    Label3.Text = "<H1> Your account is Locked because of too many failed attempts </H1>";
                    break;
                case 0: // Wrong Password, Increase the NOFA value till 5 and display maximum attempts reached
                    int NOFA = Convert.ToInt32(dSet.Tables[0].Rows[0]["NOFA"].ToString());
                    if (NOFA.Equals(5))
                    {
                        Label3.Text = "<H1> You have exceeded maximum failed attempts </H1>";
                        break;
                    }
                    Label3.Text = "<H1> Wrong Password !! You are left with " + (5 - NOFA) + " Attempts <H1>";
                    break;
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox1.Text = String.Empty;
            TextBox2.Text = String.Empty;
        }
    }
}