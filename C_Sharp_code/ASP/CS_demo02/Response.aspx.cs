using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_demo02
{
    public partial class Response : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("<h1>hello world</h1>");
            Response.End();//End()後面不再執行,大家好不顯示
            // Response.Redirect("http://www.google.com");
        }
    }
}