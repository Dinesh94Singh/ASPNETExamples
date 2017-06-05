using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPNetDemoExample1.DataPersistenceTechniquesDemos
{
    public partial class URL_QueryString_Example : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Request.QueryString["Country"] != null)
                {
                    TextBox1.Text = Request.QueryString["Country"].ToString();
                }

                if (Request.QueryString["State"] != null)
                {
                    TextBox2.Text = Request.QueryString["State"].ToString();
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("URL_QueryString_Example.aspx?Country=India&State=AndhraPradesh");
        }
    }
}