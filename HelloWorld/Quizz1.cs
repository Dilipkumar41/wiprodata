using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Quizz1
    {
        static void Main()
        {
            int x = 12;
            int y = x++ + ++x;
            Console.WriteLine(y);
        }
        
    }
}
