using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS_demo21
{
    public interface AccountOP
    {
        void deposit(double amount);
        void withdraw(double amount);
    }
}