using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS_demo21
{
    public abstract class Account
    {
        protected string name;
        protected double balance;

        public Account(double argBalance)
        {
            balance = argBalance;
        }
        public Account(string argName, double argBalance)
        {
            name = argName;
            balance = argBalance;
        }

        public double getBalance()
        {
            return balance;
        }

        public override string ToString()
        {
            return "Account:" + name + "\tBalance:" + balance;
        }
    }
}