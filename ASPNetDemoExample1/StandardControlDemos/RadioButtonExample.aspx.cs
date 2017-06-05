using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPNetDemoExample1.StandardControlDemos
{
    public partial class RadioButtonExample : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Calculate(1);
        }

        protected void CARadio_CheckedChanged(object sender, EventArgs e)
        {
            Calculate(2);
        }

        
        protected void MARadio_CheckedChanged(object sender, EventArgs e)
        {
            Calculate(3);
        }

        private void Calculate(int option)
        {
            double NetSalary, Salary, Allowances=0;

            Salary = Convert.ToDouble(TextBox1.Text);

            switch (option)
            {
                case 1: Allowances = Salary * 10 / 100;
                    break;
                case 2: Allowances = Salary * 20 / 100;
                    break;
                case 3: Allowances = Salary * 30 / 100;
                    break;
            }

            NetSalary = Allowances;
            TextBox2.Text = NetSalary.ToString();
        }
    }
}