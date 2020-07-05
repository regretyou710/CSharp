using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace Application
{
    //全域應用程式類別在專案執行中系統會呼叫的方法
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            //在專案應用程式執行時都會呼叫一次
            Application["count"] = 0;
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            //每一個瀏覽器的應用程式跟網站做連結時會執行的方法
            //不同的瀏覽器才會呼叫一次session_start
            int v1 = Convert.ToInt32(Application["count"]);
            v1 += 1;
            Application["count"] = "" + v1;
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}