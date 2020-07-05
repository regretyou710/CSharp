using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_demo25
{
    public partial class ADO連線方法 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //查看Web.config檔案之資料庫連線字串:NorthwindConnectionString1
            string str = WebConfigurationManager.
                ConnectionStrings["NorthwindConnectionString1"].ConnectionString;
            Response.Write("讀取資料庫連線字串設定:" + str);
        }
    }
}