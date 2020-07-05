using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_demo25
{
    class CheckingAccount : Account
    {
        private double 超提金額;

        public CheckingAccount(String name, double 超提金額):base(name)
        {
            this.超提金額 = 超提金額;
        }

        public override void withdraw(double amount)
        {
            if (amount < 0)
            {
                Console.WriteLine("提款金額必須大於0");
            }

            if (amount <= balance + 超提金額)
            {
                balance = balance - amount;
            }
            else
            {
                Console.WriteLine("餘額不足");
                throw new AccountException("餘額不足",accountId);
            }
        }

        public override string getDetails()
        {
            return "Type: Checking Account\r\n" +
                "AccountId: " + accountId + "\r\n" +
                "Customer: " + customer + "\r\n" +
                "Balance: " + balance + "\r\n" +
                "超提金額: " + 超提金額 ;
        }

        public void 設定超提金額(double 額度)
        {
            超提金額 = 額度;
        }
    }
}
