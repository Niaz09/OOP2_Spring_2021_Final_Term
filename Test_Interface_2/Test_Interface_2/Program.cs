using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Interface_2
{
    class Program
    {
        static void Main(string[] args)
        {
            CurrentAccount c1 = new CurrentAccount("Niaz", "7865", 50000);
            SavingsAccount c2 = new SavingsAccount("Rahim", "5643", 50000);
            OverdraftAccount c3 = new OverdraftAccount("Zidan", "2409", 50000);


        }
    }
}
