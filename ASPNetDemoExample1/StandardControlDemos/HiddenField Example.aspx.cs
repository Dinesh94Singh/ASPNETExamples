using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPNetDemoExample1.StandardControlDemos
{
    public partial class HiddenField_Example : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            double r = Convert.ToDouble(TextBox1.Text);
            double pi = Convert.ToDouble(HiddenField1.Value.ToString());

            double Area = pi * r * r;

            TextBox2.Text = Area.ToString();

            HiddenField1.Value = "4.14";
        }
    }
}