using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_demo11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            func1(5);
        }
        private void func1(int x)
        {
            int total = 1;
            for (int i = 1; i <= x; i++)
            {
                total *= i;
            }
            MessageBox.Show(total.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int msg = func2(5);
            MessageBox.Show(msg.ToString());
        }
        private int func2(int x)
        {
            int total = 1;
            int i = 1;
            do
            {
                total *= i;
                i++;
            } while (i <= x);
            return total;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            m1(date);
            MessageBox.Show(date.ToShortDateString());
        }
        private void m1(DateTime dt)
        {
            dt = dt.AddDays(1);
            MessageBox.Show(dt.ToShortDateString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            m2(ref date);
            MessageBox.Show(date.ToShortDateString());
        }
        private void m2(ref DateTime dt)
        {
            dt = dt.AddDays(1);
            MessageBox.Show(dt.ToShortDateString());
            //程式方法結束後會將dt回傳給原來的date變數
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DateTime date;
            m3(out date);
            MessageBox.Show(date.ToShortDateString());
        }

        private void m3(out DateTime dt)
        {
            dt = DateTime.Now.AddDays(2);
            MessageBox.Show(dt.ToShortDateString());
            //方法中設定完值後回傳給變數date
        }

        private void button6_Click(object sender, EventArgs e)
        {
            greet();
            greet("Tom");
            greet("Tom", TimeOfDay.Morning) ;
        }
        enum TimeOfDay { Morning, Afternoon, Evening }
        static void greet()
        {
            Console.WriteLine("Hello");
        }
        static void greet(string name)
        {
            Console.WriteLine("Hello " + name);
        }
        static void greet(string name,TimeOfDay d)
        {
            string msg ="";
            switch (d)
            {
                case TimeOfDay.Morning:
                    msg = "Morning";
                    break;
                case TimeOfDay.Afternoon:
                    msg = "Afternoon" ;
                    break;
                case TimeOfDay.Evening:
                    msg = "Evening";
                    break;
            }
            Console.WriteLine(msg+" "+name);
        }
    }
}
