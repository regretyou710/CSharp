using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_demo42
{
    public partial class 使用LINQ語法刪除資料 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                使用LINQ語法新增資料DataContext db = new 使用LINQ語法新增資料DataContext();
                var data = db.GetTable<Products>().Where(table => table.ProductID <= 10);
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

        protected void Button2_Click(object sender, EventArgs e)
        {
            使用LINQ語法新增資料DataContext db = new 使用LINQ語法新增資料DataContext();
            Products data = db.GetTable<Products>().Where(table => table.ProductID == 1).First();
            data.ProductName = "Chai";
            data.UnitPrice = (decimal)18.55;
            //data.Discontinued = true;
            db.SubmitChanges();//寫回DB
            GridView1.DataSource = db.GetTable<Products>();
            GridView1.DataBind();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string id = Request.Form["TextBox1"];
            string name = Request.Form["TextBox2"];
            decimal price = Convert.ToDecimal(Request.Form["TextBox3"]);
            bool disco = Convert.ToBoolean(Request.Form["RadioButtonList1"]);
            //Response.Write(string.Format("{0} {1} {2} {3}", id, name, price, disco));


            使用LINQ語法新增資料DataContext db = new 使用LINQ語法新增資料DataContext();
            Products data = db.GetTable<Products>().Where(table => table.ProductID.Equals(id)).First();
            data.ProductName = name;
            data.UnitPrice = price;
            data.Discontinued = disco;
            db.SubmitChanges();//寫回DB
            GridView1.DataSource = db.GetTable<Products>();
            GridView1.DataBind();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            string id = Request.Form["TextBox4"];
            使用LINQ語法新增資料DataContext db = new 使用LINQ語法新增資料DataContext();
            Products data = db.GetTable<Products>().Where(table => table.ProductID.Equals(id)).First();
            Table<Products> tb = db.GetTable<Products>();            
            tb.DeleteOnSubmit(data);
            db.SubmitChanges();//寫回DB
            GridView1.DataSource = db.GetTable<Products>();
            GridView1.DataBind();
        }
    }
}