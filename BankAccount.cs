using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Encapsulation
{
    internal class BankAccount
    {
        private double balance = 0;

        public void  deposit(double balance)
        {
            this.balance += balance;
        }
        public void withdraw(double balance)
        { this.balance -= balance; }
        public void getBalance()
        {
            Console.WriteLine(balance); 
        }
    }
    
}
