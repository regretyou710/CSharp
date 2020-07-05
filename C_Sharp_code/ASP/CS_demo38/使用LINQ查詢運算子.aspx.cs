using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_demo38
{
    public partial class 使用LINQ查詢運算子 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //列出目前執行應用程式之根目錄的實體檔案系統路徑底下檔案
            Response.Write(Request.PhysicalApplicationPath);
            IEnumerable<string> files = from file in Directory.GetFiles(Request.PhysicalApplicationPath) select file;
            foreach (string t in files)
            {//顯示檔案的byte大小
                Response.Write(t + " " + new FileInfo(t).Length+"<br/>");
            }
        }
    }
}