using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Session
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string u = Request.Form["user"];
            string p = Request.Form["pwd"];
            UserData userData = new UserData { username = u, password = p };
            Session["userdata"] = userData;
            Response.Write("將靜態頁面取得的帳號密碼存到session中</br>");                 
            Response.Write("請轉跳至WebForm2.aspx");
        }
    }
}