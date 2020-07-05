using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_demo31
{
    public partial class WebForm4_PostBack : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                TextBox1.Text = "not postback for CS";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "postback for CS";
        }
    }
}