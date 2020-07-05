using BuildComponentAndMember;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormAccessComponent
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //在參考中加入BuildComponentAndMember類別庫(2個元件)
            Customer c = new Customer()
            {
                CustomerID = "c01",
                CustomerName = "Mary"
            };
            Order o = new Order()
            {
                OrderID = "ID01",
                Product = "Apple",
                Qty = 10,
                Price = 5
            };
            c.AddOrder(o);
            o = new Order()
            {
                OrderID = "ID02",
                Product = "Banana",
                Qty = 3,
                Price = 10
            };
            c.AddOrder(o);
            foreach (Order orders in c.getOrders())
            {
                Response.Write(string.Format("產品編號:{0}\t產品名稱:{1}\t價格:{2}\t" +
            "數量:{3}</br>", orders.OrderID, orders.Product, orders.Qty, orders.Price));
            }
            Response.Write("總金額:"+c.total());
        }
    }
}