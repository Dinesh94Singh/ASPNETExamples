using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPNetDemoExample1.StandardControlDemos
{
    public partial class CheckBoxListExample : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int Salary;
            double Allowances = 0, NetSalary = 0;

            Salary = Convert.ToInt32(TextBox1.Text);

            foreach(ListItem li in CheckBoxList1.Items)
            {
                if (li.Selected)
                {
                    switch (li.Text)
                    {
                        case "HRA":
                            Allowances += Salary * 10 / 100;
                            break;
                        case "TA":
                            Allowances += Salary * 20 / 100;
                            break;
                        case "MA":
                            Allowances += Salary * 30 / 100;
                            break;
                        case "IA":
                            Allowances += Salary * 40 / 100;
                            break;
                    }
                }
            }

            NetSalary = Salary + Allowances;
            TextBox2.Text = NetSalary.ToString();
        }
    }
}