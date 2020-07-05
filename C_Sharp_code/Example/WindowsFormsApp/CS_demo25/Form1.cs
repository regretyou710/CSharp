using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace CS_demo25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = 7;
            int y = 0;
            int z;
            try
            {
                z = x / y;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            finally
            {
                Console.WriteLine("Finally 執行了");
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] array = { 1, 2, 3, 4 };
            for (int i = 0; i <= array.Length; i++)
            {
                try
                {
                    Console.WriteLine(array[i]);
                }
                catch (IndexOutOfRangeException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream file = File.Open(@"C:\abc.txt", FileMode.Open);
                Console.WriteLine(file.Length);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                CFirst cf = new CSecond();
                CThird ct = (CThird)cf;

            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        class CFirst { }
        class CSecond : CFirst { }
        class CThird : CFirst { }

        private void button5_Click(object sender, EventArgs e)
        {
            string p = @"C:\img.jpg";
            try
            {
                FileStream f = File.Open(p, FileMode.Open);
                Console.WriteLine(f.Length);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("發生錯誤:" + ex.Message);
                p = @"C:\img2.jpg";
                try
                {
                    FileStream f = File.Open(p, FileMode.Open);
                    Console.WriteLine(f.Length);
                }
                catch (FileNotFoundException ex2)
                {
                    Console.WriteLine("發生錯誤:" + ex2.Message);
                }
            }
            Console.WriteLine("END..");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int sum = 0;
            string[] a = { "1", "3", "Five", "7", "9" };
            for (int i = 0; i <= a.Length; i++)
            {
                try
                {
                    sum += Convert.ToInt32(a[i]);
                    Console.WriteLine("sum={0}", sum);
                }
                catch (FormatException ex1)
                {
                    //捕抓到例外並在離開catch範圍後迴圈還沒結束
                    Console.WriteLine("index:{0}\t{1}", i, ex1.Message);
                    //return;//使用return,後面都不會執行,程式結束
                }
                catch (IndexOutOfRangeException ex2)
                {
                    Console.WriteLine("index:{0}\t{1}", i, ex2.Message);
                }
            }
            Console.WriteLine("sum=" + sum);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            funcA();
            Console.WriteLine("程式結束");
        }

        private void funcA()
        {
            try
            {
                funB();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        private void funB()
        {
            throw new ArgumentException("自訂例外發生");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Account a1 = new CheckingAccount("Eason", 500);
            a1.deposit(100);
            Console.WriteLine(a1.getDetails());
            try
            {
                Console.WriteLine("提款700元");
                a1.withdraw(700);
            }
            catch (AccountException ex)
            {
                Console.WriteLine("-----------------");
                Console.WriteLine("發生錯誤:" + ex.Message);
            }
            Console.WriteLine("-----------------");
            Console.WriteLine(a1.getDetails());
            Console.WriteLine("執行結束");
        }
    }
}
