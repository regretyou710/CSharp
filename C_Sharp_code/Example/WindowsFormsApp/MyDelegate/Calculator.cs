using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDelegate
{
    public delegate int Calc(int x,int y);

    public delegate T Calc<T>(T x, T y);
    public delegate TResult Calc<T1,T2,TResult>(T1 x, T2 y);
    class Calculator
    {
        public delegate void Info();
        public delegate void Info<T>(T s);      
        public void information()
        {
            Console.WriteLine("計算功能");
        }
        public void information(string arg)
        {
            Console.WriteLine(arg+"計算功能");
        }
        public void information(char arg)
        {
            Console.WriteLine(arg + "計算功能");
        }
       
        public int 加(int a,int b)
        {
            int sum;
            sum = a + b;
            Console.WriteLine("{0}+{1}={2}",a,b,sum);
            return sum;
        }
        public double 加(double  a, double b)
        {
            double sum;
            sum = a + b;
            Console.WriteLine("{0}+{1}={2}", a, b, sum);
            return sum;
        }

        public int 減(int a, int b)
        {
            int sum;
            sum = a - b;
            Console.WriteLine("{0}-{1}={2}", a, b, sum);
            return sum;
        }
        public int 乘(int a, int b)
        {
            int sum;
            sum = a * b;
            Console.WriteLine("{0}*{1}={2}", a, b, sum);
            return sum;
        }
        public int 除(int a, int b)
        {
            int sum;
            sum = a / b;
            Console.WriteLine("{0}/{1}={2}", a, b, sum);
            return sum;
        }
    }
}
