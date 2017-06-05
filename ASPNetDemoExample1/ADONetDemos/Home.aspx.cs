using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ASPNetDemoExample1.App_Code;

namespace ASPNetDemoExample1.ADONetDemos
{
    public partial class ChangePassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if(Session["Sess_UserName"] != null)
                    Label1.Text = "<h1> Welcome Back to " + Session["Sess_UserName"].ToString();

            }
        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("Login.aspx");
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("ChangePassword.aspx");
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            MySessionVariables sess = new MySessionVariables();
            string userName = sess.UserName;
            string password = sess.Password;

            UserDetails x = new UserDetails();
            x.UserName = userName;
            x.Password = password;
            int Counter = x.UnSub();
            if(Counter == 1)
            {
                // Successfull
                Session.Abandon();
                Response.Redirect("SignUp.aspx");
            }
            else
            {
                // Failed
                Label1.Text = "<H1>Unsubscribe Failed </H1>";
            }
        }

        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            Response.Redirect("ChangeProfile.aspx");
        }
    }
}