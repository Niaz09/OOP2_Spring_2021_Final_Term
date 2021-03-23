using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account_Class_Final_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Account Sender = new Account("Niaz", "3421", 50000);
            Account Receiver = new Account("Mizan", "9876", 70000);

            Transaction t1 = new Transaction("Hriday", "5242", 25000,"Deposit");
            Transaction t2 = new Transaction("Peter", "9806", 30000,"Withdrawal");
            Transaction t3 = new Transaction("James", "5563", 10000,"Transfer");


        }
    }
}
