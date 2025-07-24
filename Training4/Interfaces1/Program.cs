using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ITraining[] itraining = new ITraining[]
            {
                new Thala(),new Virat()
            };
            foreach (ITraining i in itraining)
            {
                i.Email();
                i.Name();
                Console.WriteLine();
            }
        }
    }
}
