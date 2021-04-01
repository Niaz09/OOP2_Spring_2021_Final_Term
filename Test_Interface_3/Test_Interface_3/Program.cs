using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Interface_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Phone p = new Phone("Brick on the Wall", "Pink Floyd", 1982, 360);
            Ipod i = new Ipod("Sultan of Swings", "Dire Straits", 1979, 300);

            p.ShowInfo();
            i.ShowInfo();

            p.ChangeChannel();
            


        }
    }
}
