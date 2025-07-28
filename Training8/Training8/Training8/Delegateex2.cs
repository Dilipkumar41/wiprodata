using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class Delegateex2
    {
        public delegate void MyDelegate(string s);
        public static void show(string s)
        {
            Console.WriteLine("Welcome to Delegate concepts from "+s);
        }

        static void Main()
        {
            MyDelegate obj = new MyDelegate(show);
            obj("Dilip");
        }
    }

}
