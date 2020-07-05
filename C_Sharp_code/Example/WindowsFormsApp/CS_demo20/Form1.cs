using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_demo20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lion lion = new Lion();
            Console.WriteLine("name:"+lion.Name);

            Animal lion1;
            lion1 = lion;//向上隱含轉型父類別
            lion1.talk();//override 方法
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bike bike = new Bike();
            Console.WriteLine("name: "+bike.Name);
            Console.WriteLine("----------");
            Car bike1;
            bike1 = bike;
            bike1.display();//Bike class方法遮蔽後再去呼叫會是轉型後的父類方法
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Apple apple = new Apple("Apple");
            MessageBox.Show(apple.ToString());
            Apple apple2 = new Apple("Apples");
            if (apple.Equals(apple2))
                MessageBox.Show("Equals");
            else
                MessageBox.Show("Not Equals");
        }
    }
}
