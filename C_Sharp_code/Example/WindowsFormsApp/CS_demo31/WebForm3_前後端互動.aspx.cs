using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_demo31
{
    public partial class WebForm3_前後端互動 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.form1.Attributes.Add("onsubmit","return frmSubmit()");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("Server Button Event 被觸發");
        }
    }
}