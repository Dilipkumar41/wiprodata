using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Example about Multi_Cast Delegate
namespace Delegates
{
    internal class Delegateex3
    {
        public delegate void Mydelegate(int n);

        public static void Fact(int n)
        {
            int f = 1;
            for (int i = 0; i < n; i++)
            {
                f = f * i;
            }
            Console.WriteLine("Factorial of n is "+f);
        }

        public static void PosNeg(int n)
        {
            if (n >= 0)
            {
                Console.WriteLine("It is Positive number");
            }
            else
            {
                Console.WriteLine(" It is a negative  Number");
            }
        }
        public static void EveOdd(int n)
        {
            if (n % 2 == 0)
            {
                Console.WriteLine("It is a EVen Number");
            }
            else
            {
                Console.WriteLine("It is A Odd Number");
            }
        }
        public void Main()
        {
            int n;
            Console.WriteLine("Enter n value :");
            n = Convert.ToInt32(Console.ReadLine());
            Mydelegate obj = new Mydelegate(PosNeg);
            obj += new Mydelegate(Fact);
            obj += new Mydelegate(EveOdd);
            obj(n);

        }
    }
}
