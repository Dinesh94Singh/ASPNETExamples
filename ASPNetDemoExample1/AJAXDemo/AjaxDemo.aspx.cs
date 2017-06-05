using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPNetDemoExample1.AJAXDemo
{
    public partial class AjaxDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Calculate("mul");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Calculate("add");
        }
        
        private void Calculate(string str)
        {
            Double a = Convert.ToDouble(TextBox1.Text);
            Double b = Convert.ToDouble(TextBox2.Text);
            Double c = 0;


            switch (str)
            {
                case "add": c = a + b;
                    break;
                case "sub": c = a - b;
                    break;
                case "mul": c = a * b;
                    break;
                case "div": c = a / b;
                    break;
            }
            System.Threading.Thread.Sleep(5000);
            TextBox3.Text = c.ToString();

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Calculate("sub");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Calculate("div");
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            Label5.Text = DateTime.Now.ToString("hh:mm:ss");
            MyTitle.Text = Label5.Text;
        }
    }
}