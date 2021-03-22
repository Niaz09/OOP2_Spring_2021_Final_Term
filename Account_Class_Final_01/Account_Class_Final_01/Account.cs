using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account_Class_Final_01
{
    class Account
    {
        
        Transaction[] transactions;
        private int totalNumberOfTransaction;

        public string AccName { get; set; }
        public string AccId { get; set; }
        public double AccBalance { get; set; }

        public Account() { }
        public Account(string accName, string accId, double accBalance)
        {
            AccName = accName;
            AccId = accId;
            AccBalance = accBalance;
            transactions = new Transaction[20];
            totalNumberOfTransaction = 0;
        }
        public void ShowInfo()
        {
            Console.WriteLine("Name: " + AccName);
            Console.WriteLine("Acc No: " + AccId);
            Console.WriteLine("Balance: " + AccBalance);
        }
        public void Deposit(double amount)
        {
            AccBalance += amount;
        }
        public void Withdraw(double amount)
        {
            if (AccBalance >= amount)
            {
                AccBalance -= amount;
            }
            else
            {
                Console.WriteLine("Insufficient Balance");
            }
        }


        public void Transfer(Account a, double amount)
        {
            if (AccBalance >= amount)
            {
                AccBalance -= amount;
                a.AccBalance += amount;
            }
            else
            {
                Console.WriteLine("Insufficient Balance");
            }
        }

        public void AddTransaction(params Transaction[] transactions)
        {
           
        }
        public void ShowAllTransaction()
        {
            for (int i = 0; i < totalNumberOfTransaction; i++)
            {
                transactions[i].ShowInfo();
            }
        }


    }
}



