using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_demo32
{
    public partial class 伺服器端頁面方法與Session物件 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        [WebMethod]
        public static void WriteSession(string data)
        {
            HttpContext.Current.Session["PageMethods"] = data;//資料存到當前的Session
        } 
        [WebMethod]
        public static string ReadSession()
        {
            string str = HttpContext.Current.Session["PageMethods"].ToString();//取出Session
            return str;
        }
    }
}