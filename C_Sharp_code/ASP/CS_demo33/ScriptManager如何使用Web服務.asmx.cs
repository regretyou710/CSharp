﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace CS_demo33
{
    /// <summary>
    ///ScriptManager如何使用Web服務1 的摘要描述
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允許使用 ASP.NET AJAX 從指令碼呼叫此 Web 服務，請取消註解下列一行。
     [System.Web.Script.Services.ScriptService]
    public class ScriptManager如何使用Web服務1 : System.Web.Services.WebService
    {
        //取消useing註解
        
        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        [WebMethod]
        public string GetTime()
        {
            return DateTime.Now.ToLongTimeString();
        }
    }
}
