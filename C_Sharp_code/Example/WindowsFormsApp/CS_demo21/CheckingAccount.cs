using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS_demo21
{
    public class CheckingAccount : Account, AccountOP
    {
        private double 預支金額;
        const double noProtection = 500.0;
        public CheckingAccount(double argBalance) : this("NoName", argBalance, noProtection)
        {
        }

        public CheckingAccount(string argName, double argBalance, double 預支金額) : base(argName, argBalance)
        {
            this.預支金額 = 預支金額;
        }

        void AccountOP.deposit(double amount)
        {
            balance += amount;
            Console.WriteLine("Balance:" + base.balance);
        }

        void AccountOP.withdraw(double amount)
        {
            if ((balance + 預支金額 < amount))
            {
                Console.WriteLine("餘額不足");
                return;
            }
            else
            {
                balance -= amount;
                Console.WriteLine("Balance:"+base.balance);
            }
        }

        public override string ToString()
        {
            return "CheckingAccount:"+name+"\tBalance:"+base.balance+"\t預支金額:"+預支金額;
        }
    }
}