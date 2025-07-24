using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICompany obj1 = new Demo();
            obj1.Show();
            ICompany2 obj2 = new Demo();
            obj2.Show();
        }
    }
}
