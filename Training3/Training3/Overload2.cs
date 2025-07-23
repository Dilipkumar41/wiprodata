using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training3
{
    internal class Overload2
    {
        public int Sum()
        {
            return 5;
        }
        public int Sum(int x)
        {
            return x + 5;
        }
        public double Sum(double x, double y)
        {
            return x + y;
        }
        static void Main()
        {
            Overload2 overload2=new Overload2();
            Console.WriteLine("Sum w.r.t zero parameters "+ overload2.Sum());
            Console.WriteLine("Sum w.r.t single parameter "+overload2.Sum(77));
            Console.WriteLine("Sum w.r.t 2 parameters " + overload2.Sum(25.77,41.58));
        }
    }
}
