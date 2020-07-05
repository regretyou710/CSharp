using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_demo27
{
    public class Account
    {
        public event EventHandler 帳戶餘額不足;
        public event EventHandler 帳戶餘額充足;

        private double _balance;

        public void deposit(double amount)
        {
            _balance += amount;

            EventHandler handler = 帳戶餘額充足;
            //handler(Object sender,EventArgs args) => 帳戶餘額充足 => 帳戶餘額(Object sender,EventArgs args) 
            if (handler != null)
            {
                AccountEventArgs args = new AccountEventArgs(_balance);
                //EventHandler需要傳入兩個參數 1.事件的來源 2.不包含事件資料的物件
                //1.自己這個帳戶(Account class)所產生的資料,回傳出去給所真正要呼叫的方法來接收Account物件
                //2.不包含事件資料的物件->建立一個Account class(包含事件)以外的EventArgs的物件;也傳(多型(隱含向上轉型)傳入)到要對應的方法中
                
                handler(this, args);//等同handler.Invoke(this, args);
            }
        }

        public void withdraw(double amount)
        {
            _balance -= amount;

            EventHandler handler = 帳戶餘額不足;
            if (handler != null)
            {
                AccountEventArgs args = new AccountEventArgs(_balance);
                //EventHandler需要傳入兩個參數 1.事件的來源 2.不包含事件資料的物件
                //1.自己這個帳戶(Account class)所產生的資料,回傳出去給所真正要呼叫的方法來接收Account物件
                //2.也傳到要對應的方法中
                handler(this, args);
            }
        }
    }
    public class AccountEventArgs : EventArgs
    {
        //欄位
        private double _balance;

        public AccountEventArgs(double b)
        {//constructor
            _balance = b;
        }
        public double Balance
        {//屬性
            get { return _balance; }
        }
    }
}
