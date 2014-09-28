using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace BankingProblem
{
    internal class Account
    {
        public string accNum;
        public string custName;
        public double balance = 0;

        public double Deposit(double amount)
        {
            balance += amount;
            return balance;
        }

        public double Withdraw(double amount)
        {
            balance -= amount;
            return balance;
        }
        
    
}
}
