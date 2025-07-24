using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces1
{
    internal class Virat : ITraining
    {
        public void Email()
        {
            Console.WriteLine("viratkohli@gmail.com");
        }
        public void Name()
        {
            Console.WriteLine("Virat Kohli");
        }

    }
}
