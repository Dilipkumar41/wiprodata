using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Extension2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Training training = new Training();

            Console.WriteLine(training.MileStone1());
            Console.WriteLine(training.MileStone2());
            Console.WriteLine(training.MileStone3());
            Console.WriteLine(training.MileStone4());
            Console.WriteLine(training.MileStone5());


        }
    }
    
}
