using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_demo16
{
    public partial class 按鈕控制項 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Command(object sender, CommandEventArgs e)
        {
            if (e.CommandName == "sayHi")
            {
                if (e.CommandArgument == "First")
                    Response.Write("<h1>Response First</h1>");
                else
                    Response.Write("<h1>Response Second</h1>");
            }
        }
    }
}