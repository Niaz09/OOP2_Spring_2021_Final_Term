using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Interface_2
{
    class CurrentAccount : Account, BasicBankingInterface
    {
        int minimumBalance;
        public CurrentAccount() 
        {
            minimumBalance = 500;
        }
        public CurrentAccount(string accName,string accNo,int accBalance) : base(accName, accNo, accBalance) 
        {
            AccName = accName;
            AccNo = accNo;
            AccBalance = accBalance;
            minimumBalance = 500;
        }
        public bool Deposit(int amount)
        {
            AccBalance = AccBalance + amount;
            return true;
        }

        public bool Withdrawal(int amount)
        {
            if (AccBalance - amount >= minimumBalance)
            {
                return true;
            }
            else { return false; }
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Account Name: " + AccName);
            Console.WriteLine("Account No.: " + AccNo);
            Console.WriteLine("Account Balance: " + AccBalance);
        }
    }
}
