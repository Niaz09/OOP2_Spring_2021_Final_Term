using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account_Class_Abstraction_Final_00
{
    class Overdraft : Account
    {
        public int Limit = 5000;
        public Overdraft() { }
        public Overdraft(string accName, string accNo, double balance) : base(accName, accNo, balance) { }
        public override void Deposit(double amount)
        {
            Balance += amount;
        }

        public override void Transfer(Account a, double amount)
        {
            if (Balance - amount >= Limit)
            {
                Balance -= amount;
                a.Balance += amount;
                Console.WriteLine("Your account is debited by {0} to account {1} {2}", amount, a.AccName, a.AccNo);
            }
            else { Console.WriteLine("Insufficient balance"); }
        }

        public override void Withdraw(double amount)
        {
            if (Balance - amount >= Limit)
            {
                Balance -= amount;
                Console.WriteLine("Your account is credited by {0} to self", amount);
            }
            else { Console.WriteLine("Insufficient balance"); }
        }
    }
}
