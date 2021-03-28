﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Interface_1
{
    class Casio : Calculator, BasicCalculatorInterface, ScientififcCalculatorInterface
    {
        public Casio() { }
        public Casio(string name, string model) : base(name, model)
        {
            Name = Name;
            Model = Model;
        }
        public int division(int x, int y)
        {
            return y / x;
        }

        public int multiplication(int x, int y)
        {
            return x * y;
        }

        public int Power(int x, int y)
        {
            return x ^ y;
        }

        public int sub(int x, int y)
        {
            return y - x;
        }

        public int sum(int x, int y)
        {
            return x + y;
        }

        public int XtoY(int x, int y)
        {
            return x % y;
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Division: " + division(2, 3));
            Console.WriteLine("Multiplication: " + multiplication(4, 3));
            Console.WriteLine("Subtraction: " + sub(8, 7));
            Console.WriteLine("Sum: " + sum(5, 4));
            Console.WriteLine("X to Y: " + XtoY(1, 2));
        }
    }
}
