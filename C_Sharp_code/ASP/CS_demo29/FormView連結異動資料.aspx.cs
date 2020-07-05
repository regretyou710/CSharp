using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_demo29
{
    public partial class FormView連結異動資料 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            //CommandName來自CommandField轉換Template後在標籤中的屬性
            if (e.CommandName == "Select")//判斷按鈕是否為選取
            {
                FormView1.Visible = true;
                FormView1.DefaultMode = FormViewMode.Edit;//將DetailsView1模式預設改為編輯模式               
                
            }
            if (e.CommandName == "New")//判斷按鈕是否為新增
            {
                FormView1.Visible = true;
                FormView1.DefaultMode = FormViewMode.Insert;
            }
        }

        protected void FormView1_ItemUpdated(object sender, FormViewUpdatedEventArgs e)
        {
            FormView1.DefaultMode = FormViewMode.ReadOnly;
            FormView1.Visible = false;
            GridView1.DataBind();            
        }

        protected void FormView1_ItemInserted(object sender, FormViewInsertedEventArgs e)
        {
            FormView1.DefaultMode = FormViewMode.ReadOnly;
            FormView1.Visible = false;
            GridView1.DataBind();
        }
                
    }
}