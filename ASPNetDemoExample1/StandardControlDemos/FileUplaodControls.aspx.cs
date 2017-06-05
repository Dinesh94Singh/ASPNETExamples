using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPNetDemoExample1.StandardControlDemos
{
    public partial class FileUplaodControls : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpFileCollection hfc = Request.Files;

            for(int i=0; i<hfc.Count; i++)
            {
                HttpPostedFile hpf = hfc[i];
                if(hpf.ContentLength > 0)
                {
                    hpf.SaveAs(@"C:\Developer\" + hpf.FileName);
                }
            }
            Label5.Text = "<h2> Files were uploaded ... </h2>";
        }
    }
}