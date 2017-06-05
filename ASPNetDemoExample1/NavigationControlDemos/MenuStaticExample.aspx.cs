using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPNetDemoExample1.NavigationControlDemos
{
    public partial class MenuStaticExample : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Menu1_MenuItemClick(object sender, MenuEventArgs e)
        {
            string str = e.Item.Text.ToUpper();

            switch (str)
            {
                case "FORMVIEW":
                    Response.Redirect("~/DataBoundControlsDemos/FormViewExample.aspx");
                    break;
            }
        }
    }
}