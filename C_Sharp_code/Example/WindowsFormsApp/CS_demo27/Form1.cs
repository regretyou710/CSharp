using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_demo27
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Account ac = new Account();
            //委派方法前面沒有宣告event關鍵字的話如同 ,ac.帳戶餘額充足 = new EventHandler([new Form1().]帳戶餘額);的方式<[new Form1().]方法在同一個namespace可省略>
            //有加上event關鍵字委派指向的方法只能用+=註冊

            //delegate的委派方法:委派class 變數名稱 = new 委派class(委派方法);
            //evnet的委派方法:用 += new 委派class(委派方法);
            ac.帳戶餘額不足 += 帳戶餘額;//將委派指向(參考)某方法
            ac.帳戶餘額充足 += new EventHandler(帳戶餘額);//new EventHandler省略後同上
            Console.Write("存入50元,");
            ac.deposit(50);
            Console.Write("存入100元,");
            ac.deposit(100);
            Console.Write("領出20元,");
            ac.withdraw(20);
        }
        void 帳戶餘額(Object sender, EventArgs args)
        {
            AccountEventArgs e = (AccountEventArgs)args;//明確向下轉型
            double balance = e.Balance;
            Console.WriteLine("目前帳戶結餘:{0:C}", balance);//格式化貨幣
        }
                
    }
}
