using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_demo05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        enum MyColor { Red,Blue,Yellow}//列舉不能instance
        private void button1_Click(object sender, EventArgs e)
        {
            MyColor c = MyColor.Yellow;
            int index = (int)c;//列舉項目的索引由0開始
            Console.WriteLine(index);
        }
    }
}
