using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPNetDemoExample1.StandardControlDemos
{
    public partial class CalendarExample : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                DateTime dtDob = new DateTime(2017, 04, 09);
                DateTime dtToday = DateTime.Today.Date;

                int Age = (dtToday.Subtract(dtDob).Days);
                TextBox8.Text = Age.ToString();

                Calendar1.TodaysDate = dtDob; // or set it in properties.
            }
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            TextBox1.Text = Calendar1.SelectedDate.ToString();
            TextBox2.Text = Calendar1.SelectedDate.ToShortDateString();
            TextBox3.Text = Calendar1.SelectedDate.ToLongDateString();

            DateTime dt = Calendar1.SelectedDate;

            TextBox4.Text = dt.AddDays(3).ToString();
            TextBox5.Text = dt.AddMonths(5).ToString();
            TextBox6.Text = dt.AddYears(2).ToString();

            TextBox7.Text = Calendar1.SelectedDate.ToString("yyyy/MM/dd");
        }
    }
}