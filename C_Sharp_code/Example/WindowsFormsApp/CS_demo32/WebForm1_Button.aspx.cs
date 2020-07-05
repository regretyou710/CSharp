using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_demo32
{
    public partial class WebForm1_Button : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.form1.Attributes.Add("onsubmit", "return frmSubmit()");
        }

        protected void CommandBtn_Command(object sender, CommandEventArgs e)
        {
            switch (e.CommandName)
            {
                case "sort":
                    Sort_List((string)e.CommandArgument);
                    break;
                case "submit":
                    Label1.Text = "點擊了button按鈕";
                    break;
                default:
                    Label1.Text = "無法辨識命令名稱";
                    break;
            }
        }

        public void Sort_List(string commandArgument)
        {
            switch (commandArgument)
            {
                case "ascending":
                    Label1.Text = "點擊了升冪排序";
                    break;
                case "descending":
                    Label1.Text = "點擊了降冪排序";
                    break;
                default:
                    Label1.Text = "無法辨識命令名稱";
                    break;
            }
        }              
    }
}