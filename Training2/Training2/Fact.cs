using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training2
{
    internal class Fact
    {
        public void Factorial(int n)
        {
            int i = 1, f = 1;
            while (i <= n)
            {
                f = f * i;
                i++;
              
            }
            Console.WriteLine("factorial is "+f);
        }
        static void Main()
        {
            int n;
            Console.WriteLine("enter any number ");
            n=Convert.ToInt32(Console.ReadLine());
            Fact obj=new Fact();
            obj.Factorial(n);
        }
    }
}
