using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Quiz
    {
        int x;
        static void Main()
        {
            Quiz obj1 = new Quiz();
            obj1.x = 12;
            Quiz obj2=obj1;
            obj2.x = 13;
                Console.WriteLine(obj1.x);
        }
    }
}
