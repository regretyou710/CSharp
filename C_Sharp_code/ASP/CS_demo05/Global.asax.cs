using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace CS_demo05
{
    public class Global : System.Web.HttpApplication
    {
        //以下方法專案應用程式執行過程當中系統會呼叫的方法
        protected void Application_Start(object sender, EventArgs e)
        {
            //專案應用程式執行時都會呼叫一次Application_Start
            Application["Count"] = "0";
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            //每一個瀏覽器應用程式跟網站做連結的時候會執行的方法
            //不同瀏覽器會重新呼叫一次Session Start
            //同一瀏覽器執行很多其他程式時候,Session Start只會執行一次
            int c = Convert.ToInt32(Application["Count"]);
            c += 1;
            Application["Count"] = c+"";
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