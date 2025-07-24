using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employe[] arrEmploy = new Employe[]
            {
                new Emp1("Raju",1,25449),
                new Emp2("kUMAR",2,25116),
            };
            foreach(Employe e in arrEmploy)
            {
                Console.WriteLine(e);
                Console.WriteLine();
            }
        }
    }
}
