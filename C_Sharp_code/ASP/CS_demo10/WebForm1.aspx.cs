using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_demo10
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox1.Attributes.Add("onclick","alert(document.getElementById('TextBox1').value);");
        Response.Write("改變TextBox控制項Attribute屬性設定前端javascript");
        }
    }
}