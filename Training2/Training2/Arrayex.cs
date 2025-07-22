using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training2
{
    internal class Arrayex
    {
        public void show()
        {
            int[] a = new int[] { 12, 5, 6, 4, 5 };
            foreach (int i in a)
            {
                Console.WriteLine(i);
            }
        }
        
        static void Main()
        {
            Arrayex obj = new Arrayex();
            obj.show();
        }
    }
}
