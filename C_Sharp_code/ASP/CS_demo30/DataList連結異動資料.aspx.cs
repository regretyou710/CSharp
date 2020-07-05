using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_demo30
{
    public partial class DataList連結異動資料 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DataList1_EditCommand(object source, DataListCommandEventArgs e)
        {
            //e.Item.ItemIndex表示當要編輯時所選取資料的索引而發生事件
            DataList1.EditItemIndex = e.Item.ItemIndex;//取得事件發生的索引編號儲存給編輯模式的索引
            DataList1.DataBind();
        }

        protected void DataList1_UpdateCommand(object source, DataListCommandEventArgs e)
        {
            //透過Save按鈕CommandName是Update找到編輯時所屬欄位(EditItemTemplate)
            Label id = (Label)DataList1.Items[e.Item.ItemIndex].FindControl("LabProductID");//畫面有很多項目集合,透過取得事件發生的索引編號找控制項
            SqlDataSource1.UpdateParameters["ProductID"].DefaultValue = id.Text;//將更新的資料存到SqlDataSource1的對應欄位
            TextBox name = (TextBox)DataList1.Items[e.Item.ItemIndex].FindControl("TxtProductName");
            SqlDataSource1.UpdateParameters["ProductName"].DefaultValue = name.Text;
            TextBox price = (TextBox)DataList1.Items[e.Item.ItemIndex].FindControl("TxtUnitPrice");
            SqlDataSource1.UpdateParameters["UnitPrice"].DefaultValue = price.Text;
            CheckBox discon = (CheckBox)DataList1.Items[e.Item.ItemIndex].FindControl("TxtDiscontinued");
            SqlDataSource1.UpdateParameters["Discontinued"].DefaultValue = discon.Checked.ToString();
            int rs = SqlDataSource1.Update();//更新回DB

            DataList1.EditItemIndex = -1;//隱藏編輯模式
            DataList1.DataBind();

            Response.Write("<script>alert('異動筆數:" + rs + "');</script>");
        }
    }
}