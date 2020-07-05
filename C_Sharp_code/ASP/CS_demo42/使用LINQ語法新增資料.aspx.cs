using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_demo42
{
    public partial class 使用LINQ語法新增資料 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                使用LINQ語法新增資料DataContext db = new 使用LINQ語法新增資料DataContext();
                var data = db.GetTable<Products>().Where(table=>table.ProductID<=10);
                GridView1.DataSource = data;
                GridView1.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            使用LINQ語法新增資料DataContext db = new 使用LINQ語法新增資料DataContext();
            Products p = new Products();
            p.ProductName = "My New Product";
            p.UnitPrice = (decimal)99.953;
            p.Discontinued = true;
            Table<Products> table = db.GetTable<Products>();
            table.InsertOnSubmit(p);//新資料加入資料表
            db.SubmitChanges();//寫回DB
            GridView1.DataSource = table;
            GridView1.DataBind();
        }
    }
}