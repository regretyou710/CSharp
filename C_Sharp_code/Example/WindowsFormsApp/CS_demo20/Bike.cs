using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_demo20
{
    class Bike:Car
    {
       
        public new void display()//加上new關鍵字後方法被遮蔽
        {
            Console.WriteLine("Bike method");
        }
    }
}
