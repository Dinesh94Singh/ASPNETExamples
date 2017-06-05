using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPNetDemoExample1.StandardControlDemos
{
    public partial class WizardControlExample : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Wizard1_FinishButtonClick(object sender, WizardNavigationEventArgs e)
        {
            string t1 = TextBox1.Text;
            string t2 = TextBox2.Text;
            string t3 = TextBox3.Text;
            string t4 = TextBox4.Text;
            string t5 = TextBox5.Text;
            string t6 = TextBox6.Text;

            StringBuilder sb = new StringBuilder();

            sb.Append("Thank You !! The following are the details you entered..<br><br>");

            sb.Append("First Name:");sb.Append(t1);sb.Append("<br><br>");
            sb.Append("Last Name:"); sb.Append(t2); sb.Append("<br><br>");
            sb.Append("Certificate Name:"); sb.Append(t1); sb.Append("<br><br>");
            sb.Append("Certificate Name:"); sb.Append(t1); sb.Append("<br><br>");
            sb.Append("Company Name:"); sb.Append(t1); sb.Append("<br><br>");
            sb.Append("Company Name:"); sb.Append(t1); sb.Append("<br><br>");

            Label8.Text = sb.ToString();

        }
    }
}