using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training3
{
    internal class Constex
    {
        static Constex()
        {
            Console.WriteLine("Static constructor");
        }
        Constex()
        {
            Console.WriteLine("Instance constructor");
        }
        static void Main()
        {
            Constex constex = new Constex();    
        }
    }
}
