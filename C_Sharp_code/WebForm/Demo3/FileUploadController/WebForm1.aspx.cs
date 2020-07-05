using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FileUploadController
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string dirName = Server.MapPath(".");
            Response.Write("Path:"+dirName);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string dirName = Server.MapPath(".");//取得目前實體路徑位址
            string fileName = FileUpload1.FileName;//取得檔案上傳名稱
            //判斷是否有檔案在上傳
            if (FileUpload1.PostedFile != null)
            {
                try
                {
                    //判斷上傳的檔案是否已經存在
                    if (File.Exists(dirName + "/" + fileName))
                    {
                        Response.Write("檔案已經存在..");
                        Response.End();
                    }
                    else
                    {
                        FileUpload1.SaveAs(dirName + "/" + fileName);
                        Response.Write("檔案上傳成功");
                    }
                }
                catch (Exception ex)
                {
                    Response.Write("檔案上傳失敗\t"+ex.Message.ToString());
                }
            }
        }
    }
}