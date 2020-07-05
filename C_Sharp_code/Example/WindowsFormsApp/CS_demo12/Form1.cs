using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_demo12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public struct CheckingAccount
        {
            public string accountName; //帳戶名稱
            public int accountNumber; //帳戶號碼
            public decimal accountBalance; //帳戶餘額
        }

        public void output(Object anyObject)
        {
            if (anyObject!=null)
            {
                TextBox1.AppendText(anyObject.ToString() );
            }
        }
        private CheckingAccount tomCheckingAccount;
        private void Button1_Click(object sender, EventArgs e)
        {
            tomCheckingAccount = new CheckingAccount();
            tomCheckingAccount.accountName = "Tom";
            tomCheckingAccount.accountNumber = 20200423;
            tomCheckingAccount.accountBalance = 500.0M;
            string outputString = "活儲帳戶:" + tomCheckingAccount.accountName;
            outputString += "\t帳號:" + tomCheckingAccount.accountNumber;
            outputString += "\t結餘:" + tomCheckingAccount.accountBalance;
            output(outputString+"\n");
        }

        public void depositMoney(decimal amount)
        {
            //存款
            if (amount >0)
            {
                tomCheckingAccount.accountBalance += amount;
            }
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            string outputString="";
            depositMoney(500);
            outputString = "結餘:" + tomCheckingAccount.accountBalance;
            output(outputString + "\r\n");
        }
        public bool withdrawMonry(decimal amount)
        {
            if (amount > tomCheckingAccount.accountBalance || amount < 0)
                return false;
            tomCheckingAccount.accountBalance -= amount;
            return true;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            string outputString = "";
            if (withdrawMonry(900))
            {
                outputString = "結餘:" + tomCheckingAccount.accountBalance;
                output(outputString+"\r\n");
            }
            else
            {
                output("存款不足!\r\n");
            }
        }

        public bool orderCheckBook()
        {
            return true;
        }
        private void Button4_Click(object sender, EventArgs e)
        {
            string outputString = "";
            if (orderCheckBook())
                outputString = "CheckBook 已訂購";
            else
                outputString = "CheckBook 未訂購";
            output(outputString+"\r\n");
        }
    }
}
