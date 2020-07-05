using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_demo06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        struct Student
        {
            public int no;
            public string name;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Student s = new Student();
            s.no = 49780048;
            s.name = "Ken";
            Console.WriteLine("no:{0}\r\nname:{1}", s.no, s.name);
        }
    }
}
