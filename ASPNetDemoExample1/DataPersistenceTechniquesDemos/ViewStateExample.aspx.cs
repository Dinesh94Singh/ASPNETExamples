using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPNetDemoExample1.DataPersistenceTechniquesDemos
{
    public partial class DataPersistenceTechniqueExample1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // we can also use normal TextBox2.Text = TextBox1.Text, but to demonstrate we are using ViewState
            // All Controls use ViewState's internally.

            string str = TextBox1.Text;
            ViewState["vs_UserName"] = str;
            if (ViewState["vs_UserName"] != null)
            {
                TextBox2.Text = ViewState["vs_UserName"].ToString();
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }
    }
}