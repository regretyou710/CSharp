using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_demo26
{
    class SimpleMath
    {
        public static double calculator(double x)
        {
            //休息3秒
            System.Threading.Thread.Sleep(3000);
            return x * x;
        }
    }
}
