using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPNetDemoExample1.StandardControlDemos
{
    public partial class RadioButtonListController : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {

            string str = RadioButtonList1.SelectedItem.Value.ToUpper();
            Calculate(str);
            
        }

        private void Calculate(string option)
        {
            double NetSalary, Salary, Allowances = 0;

            Salary = Convert.ToDouble(TextBox1.Text);

            switch (option)
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
                case "TA":
                    Allowances = Salary * 40 / 100;
                    break;
            }

            NetSalary = Allowances;
            TextBox2.Text = NetSalary.ToString();
        }
    }
}