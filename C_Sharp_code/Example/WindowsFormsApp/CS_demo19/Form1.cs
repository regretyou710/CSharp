using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_demo19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lion lion = new Lion();//在繼承關係下子類別instance時父類別會先存在
            Console.WriteLine("name:"+lion._name);
            Console.WriteLine("------------------");
            Lion lion2 = new Lion("King");
            Console.WriteLine("name:"+lion2._name);
        }
    }
}
