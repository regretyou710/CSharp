using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_demo24
{
    public partial class 網頁表單加入使用者控制項 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack) {
                Response.Write("uesrname:" + MyLogin.UserName + "<br/>");
                Response.Write("password:" + MyLogin.Password + "<br/>");
            }
        }
    }
}