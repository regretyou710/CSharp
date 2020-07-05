using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_demo35
{
    public class Customer
    {
        //自動屬性欄位
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Company{ get; set; }
    }
    public class Company
    {
        public string CompanyName { get; set; }
        public string Country { get; set; }
    }
}
