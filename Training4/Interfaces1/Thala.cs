using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces1
{
    internal class Thala : ITraining
    {
        public void Email()
        {
            Console.WriteLine("thaladhoni@gmail.com");
        }

        public void Name()
        {
            Console.WriteLine("Mahindar singh Dhoni");
        }
    }
}
