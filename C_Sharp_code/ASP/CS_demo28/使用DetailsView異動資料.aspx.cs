using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_demo28
{
    public partial class 使用DetailsView異動資料 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
           

            //CommandName來自CommandField轉換Template後在標籤中的屬性
            if (e.CommandName == "Select")//判斷按鈕是否為選取
            {
                DetailsView1.DefaultMode = DetailsViewMode.Edit;//將DetailsView1模式預設改為編輯模式
                DetailsView1.Visible = true;               

            }
            if (e.CommandName == "New")//判斷按鈕是否為新增
            {
                DetailsView1.DefaultMode = DetailsViewMode.Insert;
                DetailsView1.Visible = true;
                
            }
            
        }

        protected void DetailsView1_ItemUpdated(object sender, DetailsViewUpdatedEventArgs e)
        {
            GridView1.DataBind();//資料異動同步顯示
        }

        protected void DetailsView1_ItemInserted(object sender, DetailsViewInsertedEventArgs e)
        {
            GridView1.DataBind();//資料異動同步顯示
        }

       
    }
}