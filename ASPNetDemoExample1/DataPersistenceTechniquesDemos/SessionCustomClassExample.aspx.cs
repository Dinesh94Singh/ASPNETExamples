using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPNetDemoExample1.DataPersistenceTechniquesDemos
{
    public partial class SessionCustomClassExample : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            MySessionVariables x = new MySessionVariables();
            x.UserName = TextBox1.Text.ToString();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            MySessionVariables x = new MySessionVariables();
            TextBox2.Text = x.UserName;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Session.Abandon();
        }
    }
}