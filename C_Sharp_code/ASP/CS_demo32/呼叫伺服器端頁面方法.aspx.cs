using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_demo32
{
    public partial class 呼叫伺服器端頁面方法 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        [WebMethod]
        public static string GetTime()
        {
            return DateTime.Now.ToLongTimeString();           
        }
    }
}