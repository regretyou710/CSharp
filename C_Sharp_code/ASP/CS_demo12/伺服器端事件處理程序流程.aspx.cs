using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_demo12
{
    public partial class 伺服器端事件處理程序流程 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string str = TextBox1.Text;
            //將VisualBasic加入參考
            bool dt = Microsoft.VisualBasic.Information.IsDate(str);//用來判斷輸入的格式是否為合法Date
            if (dt)
                Response.Write("<h1><font color='blue'>合法日期格式</font></h1>");
            else
                Response.Write("<h1><font color='red'>不合法日期格式</font></h1>");
            Response.Write("<br/>-----------------------");
        }
    }
}