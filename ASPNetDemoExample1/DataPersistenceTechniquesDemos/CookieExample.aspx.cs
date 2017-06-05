using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPNetDemoExample1.DataPersistenceTechniquesDemos
{
    public partial class CookieExample : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            /* Temporary Cookie
            HttpCookie ck1 = new HttpCookie("CK_UserName", TextBox1.Text);
            Response.Cookies.Add(ck1);
            */

            // Persistence Cookie
            HttpCookie ck2 = new HttpCookie("CK_UserName_Per", TextBox1.Text);
            ck2.Expires = DateTime.Today.AddDays(3);
            Response.Cookies.Add(ck2);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string str;
            if (Request.Cookies["CK_UserName_Per"] != null)
                str = Request.Cookies["CK_UserName_Per"].Value.ToString();
            else
                str = String.Empty;
            TextBox2.Text = str;
        }
    }
}