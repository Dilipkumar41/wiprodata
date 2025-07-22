using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training2
{
    internal class Factors
    {
        public void Factor(int n)
        {
            for(int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine("Factors are "+i);
                }
            }
        }
        static void Main()
        {
            int n;
            Console.WriteLine("Enter any number ");
            n=Convert.ToInt32(Console.ReadLine());  
            Factors obj=new Factors();
            obj.Factor(n);

        }
    }
}
