using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPNetDemoExample1.DataBoundControlsDemos
{
    public partial class GridViewExample : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow gvr = GridView1.SelectedRow;

            // in gvr.cells[0] we hv select
            TextBox1.Text = gvr.Cells[1].Text;
            TextBox2.Text = gvr.Cells[2].Text;
            TextBox3.Text = gvr.Cells[3].Text;
            TextBox4.Text = gvr.Cells[4].Text;
        }
    }
}