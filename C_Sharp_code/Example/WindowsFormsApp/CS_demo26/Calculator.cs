using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_demo26
{
    //委託類別宣告
    //delegate關鍵字+目標方法返回類型+委託方法名稱(目標方法參數類型_參數名稱)
    //委託宣告的位置,如果在namespace和class中間宣告,在instance時: Calc c1 = new Calc();
    //委託宣告的位置,如果在class內作為屬性宣告,在instance時: class的命名.Calc c1 = new class的命名.Calc();
    
    public delegate double Calc(double a, double b);//有回傳值的委派
    
    class Calculator
    {
        public delegate void Info();//沒有回傳值的委派
        public void info()
        {
            Console.WriteLine("我有4個方法");
        }
        public double add(double x, double y)
        {
            double sum = 0;
            sum = x + y;
            Console.WriteLine("{0}+{1}={2}",x,y,sum);
            return sum;
        }
        public double sub(double x, double y)
        {
            double sum = 0;
            sum = x - y;
            Console.WriteLine("{0}-{1}={2}", x, y, sum);
            return sum;
        }
        public double mul(double x, double y)
        {
            return x * y;
        }
        public double div(double x, double y)
        {
            return x / y;
        }
    }
}
