using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_demo16
{
    public partial class 文字輸入方塊控制項 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string str = Request.Form["txtName"] + ":" + Request.Form["txtPass"];
            Response.Write(str);
        }
    }
}