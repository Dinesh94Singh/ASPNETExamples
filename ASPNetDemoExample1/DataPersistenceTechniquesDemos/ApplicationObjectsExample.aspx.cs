using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPNetDemoExample1.DataPersistenceTechniquesDemos
{
    public partial class ApplicationObjectsExample : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                // There might be some synchronization errors
                int Counter = Convert.ToInt32(Application["Counter"].ToString());
                Counter++;
                Label1.Text = "<h1> You are the Visitor Numbered " + Counter.ToString();
                Application.Lock(); // set a granual lock to ensure synchronization is achieved
                Application["Counter"] = Counter;
                Application.UnLock();
            }
        }
    }
}