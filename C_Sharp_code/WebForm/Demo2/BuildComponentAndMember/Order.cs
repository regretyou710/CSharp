using System;

namespace BuildComponentAndMember
{
    public class Order
    {
        //透過自動化建立屬性
        public string OrderID { set; get; }//產品編號
        public string Product { set; get; }//產品名稱
        public int Qty { set; get; }//數量
        public int Price { set; get; }//價格
    }
}
