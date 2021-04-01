using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Interface_2
{
    class SavingsAccount : Account, BasicBankingInterface
    {
        public SavingsAccount()
        {

        }
        public SavingsAccount(string accName,string accNo,int accBalance) : base(accName, accNo, accBalance)
        {
            AccName = accName;
            AccNo = accNo;
            AccBalance = accBalance;
        }
        public bool Deposit(int amount)
        {
            AccBalance = AccBalance + amount;
            return true;
        }

        public bool Withdrawal(int amount)
        {
            float totalWithdraw = (float)(0.80 * (int)amount);
            if (amount <= totalWithdraw)
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
