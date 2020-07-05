using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_demo06
{
    public partial class Server : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string str = Server.MapPath(".");//表示現在應用程式所在的路徑位址;
            Response.Write(str);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string str = "<h1>Hello World</h1>";
            string s = Server.HtmlEncode(str);//將字串作HTML 編碼，並傳回編碼的字串。
            Response.Write(str+"<br/>");
            Response.Write(s);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
           // Response.Redirect("WebForm1.aspx");//前端進行導向,網址改變
            Server.Transfer("WebForm1.aspx");//後端進行導向,網址不變
        }
    }
}