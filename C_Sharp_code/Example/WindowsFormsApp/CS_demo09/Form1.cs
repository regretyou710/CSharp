using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
namespace CS_demo09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int s = Convert.ToInt32(Interaction.InputBox("請輸入成績:", "系統", "請輸入整數分數", 0, 0));
            string msg = "";
            if (s >= 90)
            {
                msg = "成績等級:甲";
            }
            else if (s >= 80)
            {
                msg = "成績等級:乙";
            }
            else if (s >= 70)
            {
                msg = "成績等級:丙";
            }
            else if (s >= 60)
            {
                msg = "成績等級:丁";
            }
            else
            {
                msg = "不及格";
            }
            MessageBox.Show(msg);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int s = new Random().Next(1, 101);//產生1~100的亂數整數
            MessageBox.Show("分數:" + s);
            string msg = "";
            switch (s / 10)
            {
                case 10:
                case 9:
                    msg = "甲";
                    break;
                case 8:
                    msg = "乙";
                    break;
                case 7:
                    msg = "丙";
                    break;
                case 6:
                    msg = "丁";
                    break;
                default:
                    msg = "不及格";
                    break;
            }
            MessageBox.Show(msg);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c.GetType().Equals(typeof(TextBox)))
                {
                    c.BackColor = Color.Blue;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int sum = 0;
            int count = 1;
            do
            {
                sum += count;
                count++;
            } while (count <= 1000);
            Console.WriteLine("1~1000總合:" + sum);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int sum = 0;
            int count = 1;
            while (count <= 1000)
            {
                sum += count;
                count++;
            }
            Console.WriteLine("1~1000總合:" + sum);
        }
    }
}
