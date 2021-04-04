using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_demo44_1
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //將字串以MD5編碼
            string str = FormsAuthentication.HashPasswordForStoringInConfigFile(TextBox1.Text, "MD5");
            Response.Write(str);
        }
    }
}