using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training3
{
    class First
    {
        public void Show()
        {
            Console.WriteLine("Base class method");
        }

    }
    class second : First
    {
        public void Display()
        {
            
            Console.WriteLine("Derived class method");
        }
    }

    internal class Inh2
    {
        static void Main()
        {
            second second= new second();
            second.Show();
            second.Display();
        }

    }
}
