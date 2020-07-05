using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ButtonController
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Command(object sender, CommandEventArgs e)
        {
            if (e.CommandName == "sayhi")
            {
                if (e.CommandArgument=="first")
                {
                    Response.Write("<h1>FIRST</h1>");
                }else
                {
                    Response.Write("<h1>SECOND</h1>");
                }

            }
        }
    }
}