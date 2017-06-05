using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPNetDemoExample1.NavigationControlDemos
{
    public partial class TreeViewControlStaticExample : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TreeView1_SelectedNodeChanged(object sender, EventArgs e)
        {
            string str = TreeView1.SelectedNode.Text.ToUpper();

            switch (str)
            {
                case "FORMVIEW":
                    Response.Redirect("~/DataBoundControlsDemos/FormViewExample.aspx");
                    break;
            }
        }
    }
}