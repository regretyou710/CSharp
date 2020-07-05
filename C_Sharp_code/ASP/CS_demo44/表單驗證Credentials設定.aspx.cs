using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_demo44
{
    public partial class 表單驗證Credentials設定 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            string u = Login1.UserName;
            string p = Login1.Password;
            if (FormsAuthentication.Authenticate(u,p))
            {
                e.Authenticated = true;//表示驗證成功
                FormsAuthentication.RedirectFromLoginPage(u,true);//帳號紀錄到cookie中
            }
        }
    }
}