using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_demo27
{
    public partial class 使用GridView新增資料 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            PlaceHolder1.Visible = true;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            
            //資料新增
            //SqlDataSource1:來自加入GridView控制項選擇資料來源所設定的SqlDataSource ID
            SqlDataSource1.InsertParameters["ProductName"].DefaultValue = txtName.Text;
            SqlDataSource1.InsertParameters["UnitPrice"].DefaultValue = txtPrice.Text;
            SqlDataSource1.InsertParameters["Discontinued"].DefaultValue = txtDiscon.Text;
            int rs = SqlDataSource1.Insert();
            Response.Write("異動筆數:" + rs);

            PlaceHolder1.Visible = false;
        }
    }
}