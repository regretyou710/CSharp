using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_deom03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClassA classA = new ClassA();
            classA.str = "Hello";
            Console.WriteLine(classA.str);
        }
        public class ClassA
        {
            public string str;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClassB classB = new ClassB();
            classB.x = "hi,";
            classB.y = "this's partial!";
            Console.WriteLine(classB.x+classB.y);
        }
    }
}
