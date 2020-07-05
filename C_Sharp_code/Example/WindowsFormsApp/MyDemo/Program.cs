using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDemo
{
    static class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Customer> customer = new Customer[] {
            new Customer() { FirstName="A",LastName ="A1",Age=20},
            new Customer(){FirstName="D" ,LastName="D1",Age=22},
            new Customer(){FirstName="B" ,LastName="B1",Age=22},
            new Customer(){FirstName="E" ,LastName="E1",Age=24},
            new Customer(){FirstName="C",LastName="C1",Age=25}
            };

            {
                Func<Customer, string> f = new Func<Customer, string>(Fun1);
                f = c => c.LastName;
                var r = customer.GetObj(f);
                r = customer.GetObj(c => c.LastName);

                foreach (var t in r)
                    Console.WriteLine(t);

            }
            //---------------------------------------
            {
                Func<Customer, int> f = new Func<Customer, int>(Fun2);
                f = Fun2;
                var r = GetMax(customer, f);

                foreach (var t in r)
                    Console.WriteLine(t);

            }
            Console.ReadKey();
        }


        public static List<string> GetObj(this IEnumerable<Customer> c, Func<Customer, string> func)
        {
            List<string> list = new List<string>();
            foreach (Customer t in c)
            {
                list.Add(func.Invoke(t));
            }
            return list;
        }
        public static string Fun1(Customer c)
        {
            return c.LastName;
        }

        public static List<int> GetMax(IEnumerable<Customer> c, Func<Customer, int> func)
        {
            List<int> list = new List<int>();
            foreach (Customer t in c)
            {
                int temp = 0;
                if (func.Invoke(t) >= temp)
                {
                    temp = func.Invoke(t);
                    list.Clear();
                    list.Add(func.Invoke(t));
                }

                //if (t.Age >= temp)
                //{
                //    temp = t.Age;
                //    list.Clear();
                //    list.Add(t.Age);
                //}
            }
            return list;
        }
        public static int Fun2(Customer c)
        {
            return c.Age;
        }
    }
}
