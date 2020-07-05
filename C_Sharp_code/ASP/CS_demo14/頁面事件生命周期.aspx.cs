using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_demo14
{
    public partial class 頁面事件生命周期 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Page_Load");
            Response.Write("<br/>");
        }
        protected void Page_PreInit(object sender, EventArgs e)
        {
            Response.Write("Page_PreInit");
            Response.Write("<br/>");
        }
        protected void Page_Init(object sender, EventArgs e)
        {
            Response.Write("Page_Init");
            Response.Write("<br/>");
        }
        protected void Page_PreRender(object sender, EventArgs e)
        {
            Response.Write("Page_PreRender");
            Response.Write("<br/>");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("Button1_Click");
            Response.Write("<br/>");
        }

    }
}