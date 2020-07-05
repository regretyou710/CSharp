using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_demo48_網站加入服務參考使用WCF服務
{
    public partial class 網站加入服務參考使用WCF服務 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.I網站加入服務參考使用WCF服務Client wcf = new ServiceReference1.I網站加入服務參考使用WCF服務Client();
            double add = wcf.Add(3.5, 6.4);
            Response.Write(add);
        }
    }
}