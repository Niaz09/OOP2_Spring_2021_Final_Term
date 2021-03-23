using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account_Class_Abstraction_Final_00
{
    abstract class Account
    {
        public string AccName { get; set; }
        public string AccNo { get; }
        public double Balance { get; set; }

        public Account() { }
        public Account(string accName, string accNo, double balance)
        {
            AccName = accName;
            AccNo = accNo;
            Balance = balance;
        }
        public void ShowInfo()
        {
            Console.WriteLine("Account Name: " + AccName);
            Console.WriteLine("Account Number: " + AccNo);
            Console.WriteLine("Balance:" + Balance);
        }
        abstract public void Deposit(double amount);
        abstract public void Withdraw(double amount);
        abstract public void Transfer(Account a, double amount);
    }
}
