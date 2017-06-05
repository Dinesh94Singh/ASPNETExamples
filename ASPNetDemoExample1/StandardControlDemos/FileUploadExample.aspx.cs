using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPNetDemoExample1.StandardControlDemos
{
    public partial class FileUploadExample : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                if (!FileUpload1.PostedFile.FileName.ToUpper().EndsWith("EXE")) {
                    FileUpload1.SaveAs(@"C:\Developer\" + FileUpload1.FileName);
                    Label2.Text = "<h2> Upload Done !! </h2>";

                    Label3.Text = FileUpload1.PostedFile.ContentType.ToString();
                    Label4.Text = FileUpload1.PostedFile.ContentLength.ToString();
                }
                else
                {
                    Label2.Text = "<h2> EXE files are not allowed </h2>";
                }
              
            }
            else
            {
                Label2.Text = "<h2> Please select a File.. </h2>";
            }
        }
    }
}