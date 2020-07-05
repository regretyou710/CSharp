using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Requset
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           //string u = Request.Form["username"];
           //string p = Request.Form["pas"];
           //取得附加在網址後面的表單參數
            string u = Request.QueryString["username"];
            string p = Request.QueryString["pas"];
            //取得網站環境變數的資料
            string v1 = Request.ServerVariables["SERVER_NAME"];
            string v2 = Request.ServerVariables["SCRIPT_NAME"];
            string v3 = Request.ServerVariables["REMOTE_ADDR"];
            // Response.Write("username:"+u+" "+"password:"+p);
            Response.Write("server_name:"+v1+" "+"script:"+v2+" "+"remote:"+v3);
        }
    }
}