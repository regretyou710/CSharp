using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CS_demo13_類別庫_建立元件及其成員;
namespace CS_demo13
{
    public partial class Web表單存取元件 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //CS_dmeo13_類別庫_建立元件及其成員加入參考
            Customer c1 = new Customer() { CustomerID = "c01", Name = "Eason" };
            Order o1 = new Order() { orderID = "o01", product = "Mamgo", qty = 5, price = 3 };
            c1.addOrder(o1);
            Order o2 = new Order() { orderID = "o02", product = "Banana", qty = 7, price = 5 };
            c1.addOrder(o2);
            foreach (Order t in c1.getOrders())
                Response.Write(t.orderID + "," + t.product + "," + t.qty + "," + t.price + "<br/>");
            Response.Write("Total:" + c1.total());
        }
    }
}