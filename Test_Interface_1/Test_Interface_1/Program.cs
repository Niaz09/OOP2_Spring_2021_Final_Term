using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Interface_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Citizen c1 = new Citizen("Citizen","C509");
            c1.ShowInfo();
            Console.WriteLine("********************************");
            Casio c2 = new Casio("Casio","C564");
            c2.ShowInfo();

        }
    }
}
