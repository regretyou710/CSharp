using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_demo45
{
    public partial class 目錄資源授權方式 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            if (FormsAuthentication.Authenticate(Login1.UserName, Login1.Password))
            {
                e.Authenticated = true;
                FormsAuthentication.RedirectFromLoginPage(Login1.UserName,true);//存到Cookie
            }
        }
    }
}