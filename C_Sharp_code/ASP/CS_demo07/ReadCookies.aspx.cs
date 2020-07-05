using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_demo07
{
    public partial class ReadCookies : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string s = Request.Cookies["user"].Value;          
            Response.Write("瀏覽器中Cookies: "+s);           
        }

    }
}