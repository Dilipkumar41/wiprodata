using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculation calculation = new Calculation();
            Console.WriteLine(calculation.Sum(15,225));
            Console.WriteLine(calculation.Sub(25,15));
            Console.WriteLine(calculation.Mult(25,10));
        }
    }
}
