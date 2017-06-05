using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPNetDemoExample1.StandardControlDemos
{
    public partial class BulletedListExample : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) { loadEmployees(); loadCustomers(); loadAlphabets(); }
                
        }
        private void loadAlphabets()
        {
            ListItem li;

            for (int i = 65; i <= 90; i++){

                // A - Z
                li = new ListItem(((char)i).ToString(), ((char)i).ToString());
                BulletedList4.Items.Add(li);

                // a - z
                li = new ListItem(((char)(i + 32)).ToString(), ((char)(i + 32)).ToString());
                BulletedList5.Items.Add(li);
                 
                // 0-9
                if( (i-17) <= 57){
                    li = new ListItem(((char)(i - 17)).ToString(), ((char)(i - 17)).ToString());
                    BulletedList6.Items.Add(li);
                }
            }
        }

        private void loadCustomers()
        {
            ArrayList al = new ArrayList();
            al.Add("Dinesh Singh");
            al.Add("Divya Chekuri");
            al.Add("Rachita Niranjan");

            BulletedList3.DataSource = al;
            BulletedList3.DataBind();

        }
        private void loadEmployees()
        {
            ListItem li1 = new ListItem("Dinesh Singh", "Dinesh Singh");
            ListItem li2 = new ListItem("Divya Chekuri", "Divya Chekuri");
            ListItem li3 = new ListItem("Rachita Niranjan", "Rachita Niranjan");

            BulletedList2.Items.Add(li1);
            BulletedList2.Items.Add(li2);
            BulletedList2.Items.Add(li3);
            
        }

        protected void BulletedList1_Click(object sender, BulletedListEventArgs e)
        {
            Label1.Text = BulletedList1.Items[e.Index].Text.ToString();
        }
    }
}