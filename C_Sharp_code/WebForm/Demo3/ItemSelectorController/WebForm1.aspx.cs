using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ItemSelectorController
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //新增ListBox項目
            //當網頁不是postback才產生項目
            if (!Page.IsPostBack)
            {
                ListItem items = new ListItem("1st", "1");
                ListBox1.Items.Add(items);
                items = new ListItem("2ed", "2");
                ListBox1.Items.Add(items);
                items = new ListItem("3rd", "3");
                ListBox1.Items.Add(items);
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox1.SelectedIndex = DropDownList1.SelectedIndex;
        }
    }
}