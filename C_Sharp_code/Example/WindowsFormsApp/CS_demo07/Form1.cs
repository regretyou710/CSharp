using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_demo07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int age = Convert.ToInt32(TextBox1.Text);
            if (age>=18 && TextBox2.Text.Equals("國民"))
            {
                MessageBox.Show("你可以選舉");
            }else
                MessageBox.Show("你不可以選舉");
        }
    }
}
