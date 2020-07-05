using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_demo36
{
    public partial class PageRequestManager頁面更新事件 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(3000);
            Label1.Text = DropDownList1.SelectedValue;
        }
    }
}