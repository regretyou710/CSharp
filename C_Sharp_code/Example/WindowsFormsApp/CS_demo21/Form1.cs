using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CS_demo21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ICarnivore Ilion;
            Lion alion = new Lion();            
            Antelope antelope = new Antelope();

            
            antelope.sleep();
            Ilion = alion;//將獅子轉型
            if (Ilion.IsHungry)
            {
                Animal victim;
                victim = Ilion.Hunt();
                if (victim != null)
                {
                    Ilion.Eat(victim);
                }
            }
            alion.sleep();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Lion[] lions = {new Lion("B"),new Lion("C"),new Lion ("A"),new Lion ("D") };
            //在系統呼叫排序接收到參數時,系統會去看陣列中有沒有實作compareable的介面
            //如果有實作compareto的方法，會用此方法進行比較排序
            Array.Sort(lions);
            foreach (Lion t in lions){
                Console.WriteLine("Lion name: "+t.name +" ");
                    }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //WidescreenTV tv = new WidescreenTV();
            Television tv = new WidescreenTV();//不懂特地轉型的用意為何
            Console.WriteLine(tv);
            tv.turnOn();
            tv.increaseVolume();
            tv.decreaseVolume();
            tv.turnOff();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AccountOP eason = new CheckingAccount("Eason",500.0,600.0);
            Console.WriteLine(eason);
            eason.deposit(100);
            eason.withdraw(600);
            eason.withdraw(600);
            eason.withdraw(100);
        }
    }
}
