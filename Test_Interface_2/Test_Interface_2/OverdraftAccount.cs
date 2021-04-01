using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Interface_2
{
    class OverdraftAccount : Account, BasicBankingInterface
    {
        int limitAmount = 5000;
        public OverdraftAccount() 
        {
            limitAmount = 5000;
        }
        public OverdraftAccount(string accName, string accNo, int accBalance) : base(accName, accNo, accBalance)
        {
            AccName = accName;
            AccNo = accNo;
            AccBalance = accBalance;
            limitAmount = 5000;
        }
        public bool Deposit(int amount)
        {
            AccBalance = AccBalance + amount;
            return true;
        }

        public bool Withdrawal(int amount)
        {
            if (AccBalance - amount >= limitAmount)
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
