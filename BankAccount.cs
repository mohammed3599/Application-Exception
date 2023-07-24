using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Exception
{
    internal class BankAccount
    {
        private int balance;

        public BankAccount(int balance)
        {
            this.balance = balance;
        }


        public double Withdraw(int amount)
        {
            if (amount > balance)
            {
                throw new InsufficientFundsException();
            }

            return balance -= amount;
        }

    }
}
