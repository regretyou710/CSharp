using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_demo13_類別庫_建立元件及其成員
{
    public class Customer
    {
        private string _customerID;
        private string _name;
        public List<Order> orders = new List<Order>();
        public string CustomerID
        {
            get
            {
                return _customerID;
            }
            set
            {
                _customerID = value;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public void addOrder(Order o)
        {
            orders.Add(o);
        }
        public List<Order> getOrders()
        {
            return orders;
        }

        public int total()
        {
            int sum = 0;
            if (orders.Count > 0)
            {
                foreach (Order t in orders)
                    sum += t.qty * t.price;
            }
            return sum;
        }
    }
}
