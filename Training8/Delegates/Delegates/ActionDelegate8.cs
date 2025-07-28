using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class ActionDelegate8
    {
        public delegate void MyDelegate(string str);

        public static void Greetings(string s)
        {
            Console.WriteLine("Hello Good morning Chittoor "+s);
        }
        static void Main()
        {
            MyDelegate obj = Greetings;
            obj("Dilip");
        }
    }
}
