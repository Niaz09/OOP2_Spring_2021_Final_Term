using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Interface_2
{
    abstract class Account
    {
        public string AccName { get; set; }
        public string AccNo { get; set; }
        public int AccBalance { get; set; }
        public Account() { }
        public Account(string accName,string accNo,int accBalance)
        {
            AccName = accName;
            AccNo = accNo;
            AccBalance = accBalance;
        }
        public void ShowInfo()
        {
            Console.WriteLine("Account Name: " + AccName);
            Console.WriteLine("Account No.: " + AccNo);
            Console.WriteLine("Account Balance: " + AccBalance);
        }

    }
}
