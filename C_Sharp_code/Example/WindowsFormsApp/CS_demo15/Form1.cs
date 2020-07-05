using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_demo15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Student stu = new Student();
            stu.No = 201;
            stu.Name = "Eason";
            stu.Major = "English";
            Console.WriteLine("{0},{1},{2}",stu.No,stu.Name,stu.Major);
        }
    }
}
