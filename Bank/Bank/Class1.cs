using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class Account
    {
        private double balance;
        public double Balance
        {
            get { return balance; }
        }

        public void Deposit(double amount)
        {
            balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (balance - minimumBalance < amount)
                throw new OverdraftException();
            balance -= amount;
        }

        public void Transfer(Account destination, double amount)

        {
            if (balance - minimumBalance < amount)
                throw new OverdraftException();
            destination.Deposit(amount);
            Withdraw(amount);
        }

        private double minimumBalance = 10.00;
        public double MinimumBalance
        {
            get { return minimumBalance; }
        }

        public class OverdraftException : ApplicationException
        {

        }
    }
}