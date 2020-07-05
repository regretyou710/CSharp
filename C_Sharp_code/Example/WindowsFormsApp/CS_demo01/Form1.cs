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

namespace CS_demo01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string u = textBox1.Text;
            string p = textBox2.Text;
            MessageBox.Show("帳號:" + u + "\r\n密碼:" + p, "系統訊息", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string s;
            s = Interaction.InputBox("輸入字串", "輸入視窗");//參考VB類別庫
            MessageBox.Show(s, "系統訊息", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            //this.close();
        }
    }
}
