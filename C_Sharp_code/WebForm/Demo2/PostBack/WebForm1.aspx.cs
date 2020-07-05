using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PostBack
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //向伺服器發送請求取得新的更新內容並將網頁原本內容可以被獲得的資料Post上去
            //第一次向server請求執行Page_Load不是PostBack
            if (!Page.IsPostBack) {
                //new ListItem("在ListBox中顯示的item", "點擊item回傳的值") 
                ListItem item = new ListItem("第一項", "1");
                ListBox1.Items.Add(item);
                item = new ListItem("第二項", "2");
                ListBox1.Items.Add(item);
                item = new ListItem("第三項", "3");
                ListBox1.Items.Add(item);
            }
            else
            {
                Response.Write("<H1>"+ListBox1.SelectedValue.ToString()+"</H1></br>");
            }
            Response.Write("item加入ListBox後，點選項目是沒有反應的" +
                "再將ListBox中的AutoPostBack改為true</br>");
            Response.Write("此時會發生點每點選一次項目就會呼叫一次Page_Load</br>");
        }
    }
}