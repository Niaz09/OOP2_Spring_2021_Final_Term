using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Interface_1
{
    abstract class Calculator
    {
        public string Name { get; set; }
        public string Model { get; set; }
        virtual public void ShowInfo()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Model: " + Model);
        }
    }
}
