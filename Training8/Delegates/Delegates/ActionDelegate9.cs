using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class ActionDelegate9
    {
        public static void Greeting(string s)
        {
            Console.WriteLine("Hello Good Morning "+s);
        }
        public static void EndNote(string s)
        {
            Console.WriteLine("good Night "+s);
        }
        static void Main()
        {
            Action<string> obj = Greeting;
            obj += EndNote;
            obj("Dilip");
        }
    }
}
