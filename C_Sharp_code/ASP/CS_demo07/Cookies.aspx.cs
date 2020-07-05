using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_demo07
{
    public partial class Cookies : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Cookies存到瀏覽器
            Response.Cookies["user"].Value = "admin";
            Response.Cookies["user"].Expires = DateTime.Now.AddDays(1);//Cookies到期時間,目前時間加一天後過期
            Response.Write("Cookies 失效時間: " + Response.Cookies["user"].Expires.ToString());

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("ReadCookies.aspx");
        }
    }
}