using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account_Class_Final_01
{
    class Transaction
    {
        public string AccName { get; set; }
        public string AccId { get; }
        public double AccBalance { get; set; }
        public string AdditionalInfo{get; set;}
        public Transaction() { }
        public Transaction(string accName, string accId, double accBalance,string additionalInfo)
        {
            AccName = accName;
            AccId = accId;
            AccBalance = accBalance;
            AdditionalInfo = additionalInfo;
        }
        public void ShowInfo()
        {
            Console.WriteLine("Account Name:" + AccName);
            Console.WriteLine("Account ID: " + AccId);
            Console.WriteLine("Account Balance: " + AccBalance);
            Console.WriteLine("Additional Info: " + AdditionalInfo);
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
       
    }
}