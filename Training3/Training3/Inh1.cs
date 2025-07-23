using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Training3
{
    class C1
    {
        public C1()
        {
            Console.WriteLine("Base class COnstructor");
        }
    }
    class C2 : C1
        {
            public C2()
            {
                Console.WriteLine("Derived class constructor");
            }
       }
    
   
    internal class Inh1
    {
       
        static void Main()
        {
            C2 c2 = new C2();
           

        }
    }
}
