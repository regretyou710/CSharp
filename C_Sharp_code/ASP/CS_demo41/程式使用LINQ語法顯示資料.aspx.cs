using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace CS_demo41
{
    public partial class 程式使用LINQ語法顯示資料 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {   //using陳述式可以用來簡化try{} finally{} 區塊，但並不包含 catch 的部分
            //使用using 最主要的目的是為了讓物件建立的同時能確保該物件所佔用的資源一定會被完整釋放
            using (程式使用LINQ語法顯示資料DataContext db = new 程式使用LINQ語法顯示資料DataContext())
            {
                if (!IsPostBack)
                {
                    var data = from table in db.Customers
                               where table.CustomerID.Substring(0, 1).Equals("A")
                               select table.CustomerID;
                    DropDownList1.DataSource = data;
                    DropDownList1.DataBind();
                    DropDownList1.AutoPostBack = true;
                }
            }
        }
    }
}