using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_demo24
{
    public partial class 轉換網頁表單成為使用者控制項 : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //在"設計"模式時工具列上方可直接新增表格
            //aspx檔案改變指示詞從Page換成Control
            //於Control指示詞內加入ClassName屬性名稱
            //移除元素
            //改變繼承類別為System.Web.UI.UserControl
            //建立取得textbox的屬性
            //修改aspx附檔名為ascx
        }
        public string UserName
        {
            get
            {
                return txtUser.Text;
            }
            set
            {
                txtUser.Text = value;
            }
        }
        public string Password
        {
            get
            {
                return txtPwd.Text;
            }
            set
            {
                txtPwd.Text = value;
            }
        }
    }
}