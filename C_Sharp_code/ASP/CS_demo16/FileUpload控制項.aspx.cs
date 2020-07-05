using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace CS_demo16
{
    public partial class FileUpload控制項 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("目前專案路徑:" + Server.MapPath(".")+"<br/>");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string dirName = Server.MapPath(".");//取得目錄名稱
            string fileName = FileUpload1.FileName;//取得檔案上傳名稱
            if (FileUpload1.PostedFile!=null)//判斷是否有檔案在上傳
            {
                try
                {
                    if (File.Exists(dirName + "\\" + fileName))//判斷上傳的檔案是否已經存在
                    {
                        
                        Response.Write("檔案已經存在");
                        Response.End();
                    }
                    else
                    {
                        FileUpload1.SaveAs(dirName + "\\" + fileName);
                        Response.Write("檔案上傳成功");
                    }
                }
                catch (IOException ex)
                {
                    Response.Write("檔案上傳失敗<br/>"+ex.Message);
                }
            }
        }
    }
}