using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_demo03
{
    public partial class Request : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //取得html表單value
            //string username = Request.Form["username"];
            //string password = Request.Form["password"];
            //Response.Write(string.Format("{0},{1}",username,password));

            //從aspx網址列取得參數
            string username = Request.QueryString["username"];
            string password = Request.QueryString["password"];
            Response.Write(string.Format("{0},{1}", username, password));

            Response.Write("<br/>");
            //取得網站伺服器環境變數
            string v1 = Request.ServerVariables["SERVER_NAME"];
            string v2 = Request.ServerVariables["SCRIPT_NAME"];
            string v3 = Request.ServerVariables["REMOTE_ADDR"];
            Response.Write("伺服器名稱:"+v1+"<br/>");
            Response.Write("當前文件相對路徑:" + v2 + "<br/>");
            Response.Write("遠端位址:" + v3 + "<br/>");
        }
    }
}