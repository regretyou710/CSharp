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

namespace CS_demo10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int r = new Random().Next(1, 101);
            int guess = 0;
            bool flag = false;
            for (int i = 1; i <= 3; i++)
            {
                guess = Convert.ToInt32(Interaction.InputBox("請輸入數字1~100", "視窗", "50"));
                if (guess > r)
                {
                    MessageBox.Show("Lower");
                }
                else if (guess < r)
                {
                    MessageBox.Show("Higher");
                }
                else
                {
                    flag = true;
                    break;
                }
            }
            if (flag)
                MessageBox.Show("猜中了!" + guess);
            else
                MessageBox.Show("沒猜中!" + r);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            int r = new Random().Next(1, 101);
            int guess = 0;
            //bool flag = false;
            //int i = 1;
            do
            {
                guess = Convert.ToInt32(Interaction.InputBox("請輸入數字1~100"));
                if (guess > r)
                {
                    MessageBox.Show("Lower");
                }
                else if (guess < r)
                {
                    MessageBox.Show("Higher");
                }
                else
                {
                    //flag = true;
                    break;
                }
                //i ++;
            } while (true);
            //if (flag)
            //    MessageBox.Show("猜中了!" + guess);
            // else
            //    MessageBox.Show("沒猜中!" + r);
            MessageBox.Show("猜中了!" + r);
        }
    }

}
