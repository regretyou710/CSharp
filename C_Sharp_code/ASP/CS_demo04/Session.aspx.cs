using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_demo04
{
    public partial class Session : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string user = Request.Form["user"];
            string pwd = Request.Form["pwd"];
            //建立一個類別用來接收前端傳進來的user & pwd
            UserData userData = new UserData { username = user, password = pwd };
            //將含有user & pwd物件指派給Session
            Session["datas"] = userData;
            Response.Write("前往WebForm1.aspx取出Session");
        }
    }
}