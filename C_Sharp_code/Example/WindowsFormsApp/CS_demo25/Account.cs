using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_demo25
{
    class Account
    {
        protected string accountId;
        protected string customer;
        protected double balance;
        private static int nextId = 1000;//所有帳戶共用編號

        public string AccountId
        {
            get { return accountId; }
            set { accountId = value; }
        }
        public string Customer
        {
            get { return customer; }
            set { customer = value; }
        }
        public double Balance
        {
            get
            {
                if (balance < 0)
                {
                    balance = 0;
                }
                return balance;
            }
            set
            {
                if (value < 0)
                {
                    balance = 0;
                }
                else
                {
                    balance = value;
                }
            }
        }

        public Account(string customer)
        {
            this.customer = customer;
            accountId = "A" + nextId++;
            Console.WriteLine(accountId + "\t" + customer + "帳號建立");
        }
        public void deposit(double amount)
        {   //存款
            if (amount > 0)
            {
                balance = balance + amount;
            }
            else
            {
                Console.WriteLine("存款金額必須大於0");
            }
        }

        public virtual void withdraw(double amount)
        {     //提款
            if (amount < 0)
            {
                Console.WriteLine("提款金額必須大於0");
            }

            if (amount <= balance)
            {
                balance = balance - amount;
            }
            else
            {
                Console.WriteLine("餘額不足");
                throw new AccountException("餘額不足",accountId);
            }
        }

        public virtual string getDetails()
        {
            return "Type: Account\r\n" +
                "AccountId: " + accountId + "\r\n" +
                "Customer: " + customer + "\r\n" +
                "Balance: " + balance + "\r\n";
        }
    }
}
