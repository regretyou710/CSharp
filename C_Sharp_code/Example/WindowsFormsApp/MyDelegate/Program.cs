using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MyDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            //無回傳值
            Calculator.Info info = new Calculator.Info(calculator.information);
            info.Invoke();

            //簡寫等同
            //Calculator.Info _info = calculator.information;
            //_info();


            //有回傳值,NET1.0
            {
                Calc calc = new Calc(calculator.加);
                calc.Invoke(10, 2);
            }
            //簡寫等同
            //Calc _calc = calculator.加;
            //_calc(10, 2);


            //有回傳值,NET2.0(匿名方法)
            {//把整個方法放進Calc參數傳遞,拿掉修飾詞和回傳型別改成delegate
                Calc calc = new Calc(delegate (int a, int b)
               {
                   int sum;
                   sum = a + b;
                   Console.WriteLine("{0}+{1}={2}", a, b, sum);
                   return sum;
               });
                calc.Invoke(10, 2);
            }


            //有回傳值,NET3.0(Lambda表達式)
            {//拿掉delegate關鍵字加上=>表示,左邊是參數列表右邊是方法主體
                //Lambda表達式本質是匿名方法也就是個方法
                Calc calc = new Calc((int a, int b) =>
                {
                    int sum;
                    sum = a + b;
                    Console.WriteLine("{0}+{1}={2}", a, b, sum);
                    return sum;
                });
                calc.Invoke(10, 2);
            }

            //再更精簡
            {//方法參數拿掉型別,透過糖果編譯器進行型別推斷
                Calc calc = new Calc((a, b) =>
                {
                    int sum;
                    sum = a + b;
                    Console.WriteLine("{0}+{1}={2}", a, b, sum);
                    return sum;
                });
                calc.Invoke(10, 2);
            }

            //委派的泛型使用
            {
                //有回傳值
                Calc<double> calc1 = calculator.加;
                calc1(30.0, 5.0);
                Calc<int> calc2 = calculator.加;
                calc2(30, 5);
                Calc<double, double, double> calc3 = calculator.加;
                calc3(20.0, 3.0);
                Calc<int, int, int> calc4 = calculator.加;
                calc3(20.0, 3.0);

                //沒有回傳值帶參數
                Calculator.Info<string> info1 = calculator.information;
                info1("卡西歐");
                info1 = arg => Console.WriteLine(arg + "計算功能");
                info1("雜牌");
            }

            //Action系統提供的沒有回傳參數的委派型別
            {
                Action act1 = new Action(calculator.information);
                act1 = calculator.information;
                act1 = delegate () { Console.WriteLine("計算功能"); };
                act1 = () => { Console.WriteLine("計算功能"); };
                act1 = () => Console.WriteLine("計算功能");
                act1();
            }

            //Func系統提供的有回傳參數的泛型委派型別
            //因為會回傳值所以一定會用泛型(至少要回傳型別)
            {
                Func<int, int, int> fun1 = new Func<int, int, int>(calculator.乘);
                fun1 = calculator.乘;
                fun1 = delegate (int a, int b)
                {
                    int sum;
                    sum = a * b;
                    Console.WriteLine("{0}*{1}={2}", a, b, sum);
                    return sum;
                };

                fun1 = (a, b) =>
                {
                    int sum;
                    sum = a * b;
                    Console.WriteLine("{0}*{1}={2}", a, b, sum);
                    return sum;
                };

                fun1(5, 5);
            }

            Console.ReadKey();
        }
    }
}
