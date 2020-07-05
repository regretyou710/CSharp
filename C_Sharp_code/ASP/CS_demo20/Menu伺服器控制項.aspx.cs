using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_demo20
{
    public partial class Menu伺服器控制項 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Menu1_MenuItemClick(object sender, MenuEventArgs e)
        {
            //if (e.Item.Value == "高麗菜")
                Response.Write("<h1>"+e.Item.Value+"</h1>");
        }
    }
}