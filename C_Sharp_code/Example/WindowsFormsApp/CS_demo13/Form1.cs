using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_demo13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] n;
            n = new string[3];
            n[0] = "Apple";
            n[1] = "Banana";
            n[2] = "Mango";
            for (int i = 0; i < n.GetLength(0); i++)
            {
                Console.WriteLine("n[{0}]={1}", i, n[i]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //string[][] n;
            // n = new string[2][];
            //  n[0] = new string[4];
            //  Console.WriteLine(n[0].Length);
            string[,] n;
            n = new string[2, 2];
            for (int i = 0; i < n.GetLength(0); i++)
            {
                for (int j = 0; j < n.GetLength(1); j++)
                {
                    n[i, j] = "Array:" + i + j;
                }
            }
            for (int i = 0; i < n.GetLength(0); i++)
            {
                for (int j = 0; j < n.GetLength(1); j++)
                {
                    Console.WriteLine("n[{0}][{1}]={2}", i, j, n[i, j]);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] data = { "Tom", "Mary", "Tim", "Judy", "Eason" };
            for (int i = 0; i < data.Length; i++)
            {
                Console.WriteLine("data[{0}]={1}", i, data[i]);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string[,] data = { { "X", "Y" }, { "A", "B" } };
            for (int i = 0; i < data.GetLength(0); i++)
            {
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    Console.WriteLine("data[{0},{1}]={2}", i, j, data[i, j]);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string[] data = { "Tom", "Mary", "Tim", "Judy", "Eason" };
            for (int i = 0; i < data.Length; i++)
            {
                Console.WriteLine("data[{0}]={1}", i, data[i]);
            }
            string[] newData = new string[10];
            Array.Copy(data, newData, data.Length);
            for (int i = 0; i < newData.Length; i++)
            {
                Console.WriteLine("newData[{0}]={1}", i, newData[i]);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string[,] data = { { "X", "Y" }, { "A", "B" } };
            for (int i = 0; i < data.GetLength(0); i++)
            {
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    Console.WriteLine("data[{0},{1}]={2}", i, j, data[i, j]);
                }
            }

            string[,] newData = new string[3, 3];
            for (int i = 0; i < data.GetLength(0); i++)
            {
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    newData[i, j] = data[i, j];
                }
            }

            for (int i = 0; i < newData.GetLength(0); i++)
            {
                for (int j = 0; j < newData.GetLength(1); j++)
                {
                    Console.WriteLine("newData[{0},{1}]={2}", i, j, newData[i, j]);
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string[] str = { "X", "A", "Y", "B", "Z" };

            foreach (string s in str)
            {
                Console.Write("{0}{1}", s, "\t");
            }
            Console.WriteLine();
            Array.Sort(str);
            foreach (string t in str)
            {
                Console.Write(t + "\t");

            }
            Console.WriteLine();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string[] str = { "X", "A", "Y", "B", "Z" };
            foreach (string s in str)
            {
                Console.Write("{0}{1}", s, "\t");
            }
            Console.WriteLine();
            int i1 = Array.IndexOf(str, "Y");
            int i2 = Array.IndexOf(str, "U");
            Console.WriteLine(i1 + " " + i2);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string[] str = { "X", "A", "Y", "B", "Z" };
            foreach (string s in str)
            {
                Console.Write("{0}{1}", s, "\t");
            }
            Console.WriteLine("\r\n----------");
            string[] str2;
            str2 = (string[])str.Clone();
            foreach (string s in str2)
            {
                Console.Write("{0}{1}", s, "\t");
            }
            Console.WriteLine();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int[] data = { 1, 2, 3, 4, 5 };
            func(data);
            foreach (int t in data)
            {
                Console.Write("{0}{1}", t, "\t");
            }
            Console.WriteLine();
        }

        private void func(int[] arg)
        {
            for (int i = 0; i < arg.Length; i++)
            {
                arg[i]++;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            func2(1, 2, 3);
            func2(11, 13, 15, 17, 19);
        }
        private void func2(params int[] args)
        {
            foreach (int t in args)
            {
                Console.Write(t + "\t");
            }
            Console.WriteLine();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int[][] data = new int[3][];
            data[0] = new int[1];
            data[1] = new int[2];
            data[2] = new int[3];
            for (int i = 0; i < data.GetLength(0); i++)
            {
                for (int j = 0; j < data[i].Length; j++)
                {
                    data[i][j] = (i + 1) * (j + 1);
                }
            }
            for (int i = 0; i < data.GetLength(0); i++)
            {
                for (int j = 0; j < data[i].Length; j++)
                {
                    Console.Write("data[{0}][{1}]={2}\t", i, j, data[i][j]);
                }
                Console.WriteLine();
            }

        }

        private void button13_Click(object sender, EventArgs e)
        {
            int[] numbers = new int[6];
            Random r = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = r.Next(1, 101);
                Console.Write(numbers[i] + "\t");
            }
            Console.WriteLine();
            Array.Sort(numbers);
            foreach (int t in numbers)
                Console.Write(t + "\t");
            Console.WriteLine();
        }

        struct Student
        {
            public int no;
            public string name;
            public string major;
        }
        private void button14_Click(object sender, EventArgs e)
        {
            Student[] stu = new Student[] { new Student(), new Student(), new Student() };
            for (int i = 0; i < stu.Length; i++)
            {
                stu[i].no = i + 1;
            }
            stu[0].name = "Eason";
            stu[1].name = "Judy";
            stu[2].name = "Rose";
            stu[0].major = "國文";
            stu[1].major = "英文";
            stu[2].major = "數學";
            foreach (Student t in stu)
            {
                Console.WriteLine("{0},{1},{2}", t.no, t.name, t.major);
            }
        }
    }
}
