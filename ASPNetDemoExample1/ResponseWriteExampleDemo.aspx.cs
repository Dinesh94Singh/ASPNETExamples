using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPNetDemoExample1
{
    // Since this class is executed along with the actual aspx file, this is achieved with partial
    public partial class ResponseWriteExampleDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Welcome to ASP.NET File");
            Response.Write("<br> <b> How are you doing today </b>");
            Response.Write("<br><b><i><u> I'm Doing good thank you for asking </b></i></u>");

            Response.Write("<br><br><ul><li> ASP.NET </li><li> ASP.NET MVC</li> </ul>");

            Response.Write("<table border='5' 'bgcolor'='aqua'>");
            Response.Write("<tr><td>Course Name</td> <td> Course Number </td></tr>");
            Response.Write("<tr><td>C#</td> <td> CS5200 </td></tr>");
            Response.Write("<tr><td>ASP.Net</td> <td> CS5300 </td></tr>");
            Response.Write("</table>");
        }
    }
}