using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPNetDemoExample1.DataPersistenceTechniquesDemos
{
    public partial class SessionExample : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                Label6.Text = Session.Timeout.ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session.Timeout = 100000;
            Session["Session_UserName"] = TextBox1.Text;
            Label5.Text = Session.SessionID.ToString();
            Label6.Text = Session.Timeout.ToString();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox2.Text = Session["Session_UserName"].ToString();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Session["Session_UserName"] = TextBox1.Text;
            Response.Redirect("TestSessionData.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
           Session.Timeout = 200000;
        }
    }
}