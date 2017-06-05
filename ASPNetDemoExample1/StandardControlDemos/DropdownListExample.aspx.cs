using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPNetDemoExample1.StandardControlDemos
{
    public partial class DropdownListExample : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Customers();
                Employees();
                Alphabets();
            }
        }

        private void Alphabets()
        {
            ListItem li = null;
            for (int i = 65; i < 90; i++)
            {
                li = new ListItem(((char)i).ToString(), ((char)i).ToString());
                DropDownList4.Items.Add(li);

                li = new ListItem(((char)(i + 32)).ToString(), ((char)(i + 32)).ToString());
                DropDownList5.Items.Add(li);

                if ((i - 17) <= 57) {
                    li = new ListItem(((char)(i - 17)).ToString(), ((char)(i - 17)).ToString());
                    DropDownList6.Items.Add(li);
                }
            }
        }
        private void Employees()
        {
            ArrayList al = new ArrayList();
            al.Add("Dinesh Singh");
            al.Add("Divya Chekuri");
            al.Add("Rachita Niranjan");

            DropDownList3.DataSource = al;
            DropDownList3.DataBind();
        }
        private void Customers()
        {
            ListItem li1 = new ListItem("Dinesh Singh", "Dinesh Singh");
            ListItem li2 = new ListItem("Divya Chekuri", "Divya Chekuri");
            ListItem li3 = new ListItem("Rachita Niranjan", "Rachita Niranjan");

            DropDownList2.Items.Add(li1);
            DropDownList2.Items.Add(li2);
            DropDownList2.Items.Add(li3);
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextBox1.Text = DropDownList1.SelectedItem.Value;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DropDownList6.Items.Clear();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string str = TextBox2.Text;

            // DropDownList6.Items.Remove(str); // we can also use the listitem instead of str
            // TextBox3.Text = DropDownList6.Items.Count.ToString();


            // to find the index of deleted item
            ListItem li = DropDownList6.Items.FindByText(str);

            if(li != null)
            {
                int index = DropDownList6.Items.IndexOf(li);
                DropDownList6.Items.RemoveAt(index);
                Console.WriteLine("Deleted at position" + index.ToString());
                TextBox3.Text = DropDownList6.Items.Count.ToString();
            }

            
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string str = TextBox2.Text;
            ListItem li = new ListItem(str, str);
            DropDownList6.Items.Insert(2, li);
            

        }
    }
}