using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hero[] arrHero = new Hero[]
            {
                new Hero1(),
                new Hero2(),
                new Hero3()
            };
            foreach (Hero h in arrHero)
            {
                h.Name();
                h.count();
                h.Type();

                Console.WriteLine("...................");

            }
        }
    }
}
