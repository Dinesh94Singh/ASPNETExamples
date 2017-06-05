using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPNetDemoExample1.StandardControlDemos
{
    public partial class CheckBoxExample : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            Calculate("HRA", CheckBox1.Checked);
        }

        protected void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            Calculate("IA", CheckBox2.Checked);
        }

        

        protected void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            Calculate("MA", CheckBox3.Checked);
        }

        private void Calculate(String v, bool @checked)
        {
            double NetSalary, Salary, Allowances = 0;

            Salary = Convert.ToDouble(TextBox1.Text);
            NetSalary = Convert.ToDouble(TextBox2.Text);

            if(NetSalary.Equals(0))
            {
                NetSalary = Salary;
            }

            switch (v)
            {
                case "HRA":
                    Allowances = Salary * 10 / 100;
                    break;
                case "MA":
                    Allowances = Salary * 20 / 100;
                    break;
                case "IA":
                    Allowances = Salary * 30 / 100;
                    break;
            }

            if (@checked){
                NetSalary += Allowances;
            }
            else
            {
                NetSalary -= Allowances;
            }

            TextBox2.Text = NetSalary.ToString();
        }
    }
}