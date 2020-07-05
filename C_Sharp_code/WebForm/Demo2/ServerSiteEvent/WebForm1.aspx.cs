using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ServerSiteEvent
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string d = TextBox1.Text;
            //在方案總管->參考右鍵加入參考->Microsoft.VisualBasic
            //判斷request傳送進的來的日期格式是否正確
            bool b1 = Microsoft.VisualBasic.Information.IsDate(d);
            if (b1)
            {
                Response.Write("This is a Date type");
            }
            else
            {
                Response.Write("This is not a Date type");
            }
        }
    }
}