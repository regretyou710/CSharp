using System;
using System.Collections.Generic;
using System.Text;

namespace BuildComponentAndMember
{
    public class Customer
    {
        private string cid;
        private string name;
        List<Order> orders = new List<Order>();
        public string CustomerID
        {
            set
            {
                cid = value;
            }
            get
            {
                return cid;
            }
        }
        public string CustomerName
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }

        //每位顧客會有N筆訂單
        public void AddOrder(Order o)
        {
            orders.Add(o);
        }
        //顯示出顧客有哪些訂單
        public List<Order> getOrders()
        {
            return orders;
        }
        //價格總計
        public int total()
        {
            int sum = 0;
            //有訂單才做計算
            if (orders.Count > 0)
            {
                foreach (Order o in orders)
                {
                    sum += o.Qty * o.Price;
                }
            }
            return sum;
        }
    }
}
