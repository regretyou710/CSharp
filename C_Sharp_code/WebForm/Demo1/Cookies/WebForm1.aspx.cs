using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cookies
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //定義一個叫做user的cookies值為Eason Cookies
            Response.Cookies["user"].Value = "Eason Cookies";
            //設定cookies的有效期間為現在時間加一天
            Response.Cookies["user"].Expires = DateTime.Now.AddDays(1);
            Response.Write("寫入cookies後到WebForm2讀取cookies");
            Response.Write("</br>");
            Response.Write("Expire:" + Response.Cookies["user"].Expires);
        }
    }
}