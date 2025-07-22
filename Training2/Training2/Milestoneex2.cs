using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training2
{
    internal class Milestoneex2
    {
        static void Main()
        {
            string data="hi welcome to wipro training session by prasanna sir";
            string[] names = data.Split(' ');
            foreach(String name in names)
            {
                Console.WriteLine(name);
            }

        }
    }
}
