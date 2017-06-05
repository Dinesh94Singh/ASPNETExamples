using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPNetDemoExample1.StandardControlDemos
{
    public partial class TextBoxExample : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                lblEmployeeName.Focus();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            double NetSalary, Salary, HRA, TA, MA;

            Salary = Convert.ToDouble(TextBox2.Text);
            HRA = Convert.ToDouble(TextBox3.Text);
            TA = Convert.ToDouble(TextBox4.Text);
            MA = Convert.ToDouble(TextBox5.Text);

            NetSalary = Salary + HRA + TA + MA;

            TextBox8.Text = NetSalary.ToString();

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            lblEmployeeName.Text = "";
            TextBox2.Text = String.Empty;
            TextBox3.Text = String.Empty;
            TextBox4.Text = String.Empty;
            TextBox5.Text = String.Empty;
            TextBox6.Text = String.Empty;
            TextBox7.Text = String.Empty;
            TextBox8.Text = String.Empty;
            lblEmployeeName.Focus();
        }
    }
}