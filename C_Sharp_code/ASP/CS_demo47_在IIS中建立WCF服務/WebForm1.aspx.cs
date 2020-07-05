using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_demo47_在IIS中建立WCF服務
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            I在IIS中建立WCF服務Client wcf = new I在IIS中建立WCF服務Client();
            double add = wcf.Add(5.3, 4.2);
            Response.Write(add);
        }
    }
}