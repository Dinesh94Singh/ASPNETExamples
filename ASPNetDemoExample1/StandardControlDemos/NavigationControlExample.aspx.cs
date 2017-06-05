using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPNetDemoExample1.StandardControlDemos
{
    public partial class NavigationControlExample : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("TextBoxExample.aspx");
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            if (e.X < 200)
                Server.Transfer("TextBoxExample.aspx");
            else
                Server.Transfer("~/ResponseWriteExampleDemo");
        }
    }
}