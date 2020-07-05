using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Server
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //用.來表示目前執行程式所在的實體路徑位址
           string s =  Server.MapPath(".");
            Response.Write(s);


        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string s = "<h1>Hello World</h1>";
           // string s1 = Server.HtmlEncode(s);
            Response.Write(s);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            //網址轉成WebForm2.aspx,由前端進行轉址
           // Response.Redirect("WebForm2.aspx");
            //網址仍是WebForm1.aspx,由後端進行轉址
            Server.Transfer("WebForm2.aspx");
        }
    }
}