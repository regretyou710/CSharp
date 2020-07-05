using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_demo43
{
    public partial class 檔案加密設定 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string 連線字串 = WebConfigurationManager.ConnectionStrings["NorthwindConnectionString"].ConnectionString;
            Response.Write(連線字串);
        }
    }
}