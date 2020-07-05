using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_demo34
{
    public partial class 使用UpdatePanel執行更新 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = DateTime.Now.ToLongTimeString();
            Label2.Text = DateTime.Now.ToLongTimeString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //或者到UpdatePanel2屬性中設定
            UpdatePanel2.Update();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }
    }
}