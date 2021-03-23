using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account_Class_Abstraction_Final_00
{
    class Program
    {
        static void Main(string[] args)
        {
            Account a1 = new Special_Savings_Account("Niaz", "6997", 8000);
            Account a2 = new Overdraft("Shabab", "5643", 8000);

            Account[] accounts = new Account[10];
            accounts[0] = a1;
            accounts[1] = a2;

            a1.ShowInfo();
            accounts[0].Withdraw(8000);
            accounts[0].Transfer(a1, 8000);

            a2.ShowInfo();
            accounts[1].Withdraw(8000);
            accounts[1].Transfer(a2, 8000);
        }
    }
}
