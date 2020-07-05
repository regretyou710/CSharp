using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FrontPageEventCycle
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        //頁面載入時方法生命週期先後順序
       
        protected void Page_Load(object sender, EventArgs e)
        { //Page_Load頁面在載入時一定會執行的方法
            Response.Write("Page_Load</br>");
        }
        protected void Page_PreInit(object sender, EventArgs e)
        {
            Response.Write("Page_PreInit</br>");
        }
        protected void Page_Init(object sender, EventArgs e)
        {
            Response.Write("Page_Init</br>");
        }
        protected void Page_PreRender(object sender, EventArgs e)
        {
            Response.Write("Page_PreRender</br>");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("Button1_Click</br>");
        }
    }
}