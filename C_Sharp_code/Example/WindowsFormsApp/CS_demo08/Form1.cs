using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Windows.Forms;


namespace CS_demo08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 1;
            int b = 2;
            a = b++;
            Console.WriteLine("{0}{1}", a, b);
            a = ++b;
            Console.WriteLine("{0}{1}", a, b);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = 1;
            int b = 2;
            a = b--;
            Console.WriteLine("{0}{1}", a, b);
            a = --b;
            Console.WriteLine("{0}{1}", a, b);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //位元移動
            //轉為2進位再向左或向右移動
            int a = 2;
            a >>= 1;//向右移動1個位元
            Console.WriteLine("{0}", a);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //位元移動
            //轉為2進位再向左或向右移動
            int a = 2;
            a <<= 1;//向左移動1個位元
            Console.WriteLine("{0}", a);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int a = 1;
            int b = 2;
            int c = a ^ b;//a,b轉為2進位兩者做是否為互斥
            Console.WriteLine("{0}", c);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Interaction.InputBox("請輸入一個數字", "視窗"));
            String s;
            s = x % 2 == 0 ? "偶數" : "奇數";
            MessageBox.Show(s);
        }
    }
}
