using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_demo16
{
    public partial class Calendar日曆控制項 : System.Web.UI.Page
    {
        string[,] dayoffs = new string[13, 32];//建立2維陣列,存放12個月,31天,index 0不使用
        protected void Page_Load(object sender, EventArgs e)
        {
            dayoffs[5, 1] = "勞動節";
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            //sender參數就是Calendar物件
            //將目前所選日期顯示出來
            string str = ((Calendar)sender).SelectedDate.ToShortDateString();
            Response.Write("<h1>" + str + "</h1>");
        }

        protected void Calendar1_DayRender(object sender, DayRenderEventArgs e)
        {
            //已經在 dayoffs[5, 1]中有設定文字
            //在選取的日期格子中顯示出設定文字
            if (dayoffs[e.Day.Date.Month, e.Day.Date.Day] != "")
            {
                e.Cell.Controls.Add(new LiteralControl("</br>"
                    + dayoffs[e.Day.Date.Month, e.Day.Date.Day] + "</br>"));
            }
        }
    }
}