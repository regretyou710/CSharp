using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AddAndSettingHTMLController
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string s = Request.Form["user"];
            string p = Request.Form["pwd"];
            Response.Write(string.Format("Username:{0}\tPassword:{1}",s,p));
        }
    }
}