using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class FunctionDelegate10
    {
        public static int Fact(int n)
        {
            int f = 1;
            for(int i=0; i<+n; i++)
            {
                f = f * 1;
            }
            return f;
        }
        static void Main()
        {
            int n;
            Console.WriteLine("Enter the value of n");
            n= Convert.ToInt32(Console.ReadLine());
            Func<int, int> obj = Fact;
            Console.WriteLine("Factorial is"+obj(n));
        }
    }
}
