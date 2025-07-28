using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class Delegateex1
    {
        public delegate void myDelegate();

        public static void show()
        {
            Console.WriteLine("Welcome TO Delegate");

        }
        static void Main(string[] args)
        {
            myDelegate obj = new myDelegate(show);
            obj();
        }
    }
}
