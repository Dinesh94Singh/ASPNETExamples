using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPNetDemoExample1.ValidationControlDemos
{
    public partial class VadlidationDemo : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            string str = TextBox1.Text.Trim().ToString();

            if(str.Length < 5)
            {
                // error
                args.IsValid = false;
            }
            else
            {
                args.IsValid = true;
            }

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Write("Login Successfull");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {

        }
    }
}