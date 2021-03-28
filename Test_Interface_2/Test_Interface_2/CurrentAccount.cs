using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Interface_2
{
    class CurrentAccount : Account, BasicBankingInterface
    {
        public CurrentAccount() { }
        public CurrentAccount(string accName,string accNo,int accBalance) : base(accName, accNo, accBalance) 
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

        }
    }
}
