using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPNetDemoExample1.StandardControlDemos
{
    public partial class MultiViewExample : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            if(MultiView1.ActiveViewIndex >= 1)
                MultiView1.ActiveViewIndex -= 1;
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = MultiView1.Views.Count - 1;
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 0;
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            if (MultiView1.ActiveViewIndex < MultiView1.Views.Count - 1)
                MultiView1.ActiveViewIndex += 1;
        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = RadioButtonList1.SelectedValue.ToString().ToUpper();

            switch (str)
            {
                case "AQ":
                    MultiView1.SetActiveView(View4);
                    break;
                case "CO":
                    MultiView1.SetActiveView(View3);
                    break;
                case "Details":
                    MultiView1.SetActiveView(View2);
                    break;
                case "WK":
                    MultiView1.SetActiveView(View1);
                    break;
            }
        }
    }
}