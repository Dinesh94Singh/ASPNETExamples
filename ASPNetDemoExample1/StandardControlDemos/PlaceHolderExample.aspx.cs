using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPNetDemoExample1.StandardControlDemos
{
    public partial class PlaceHolderExample : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label l1 = new Label();
            Label l2 = new Label();

            TextBox t1 = new TextBox();
            TextBox t2 = new TextBox();

            Button b1 = new Button();
            Button b2 = new Button();

            b1.Text = "Login";
            b2.Text = "Cancel";

            l1.Text = "User Name";
            l2.Text = "Password";

            PlaceHolder1.Controls.Add(l1);
            PlaceHolder1.Controls.Add(t1);
            PlaceHolder1.Controls.Add(l2);
            PlaceHolder1.Controls.Add(t2);
            PlaceHolder1.Controls.Add(b1);
            PlaceHolder1.Controls.Add(b2);


        }
    }
}