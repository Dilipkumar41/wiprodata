using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training3
{
    internal class Constover
    {
        int a, b;
        public Constover()
        {
            a = 5;
            b = 10;
        }
        public Constover(int a, int b)
        {
            this.a = a;
            this.b = b;
        } 
        public void Display()
        {
            Console.WriteLine("A value is "+a);
            Console.WriteLine("B vale is "+b);
        }
        static void Main()
        {
            Constover constover1 = new Constover();
            constover1.Display();
            Constover constover2 = new Constover(22,25);
            constover2.Display();
        }
    }
}
