using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training2
{
    internal class Max
    {
        public void Maximum(int a, int b, int c)
        {
            int m = a;
            if (m < b)
            {
                m = b;
            }
            if (m < c)
            {
                m = c;
            }
            Console.WriteLine("Maximum number is "+ m);
        }
        static void Main()
        {
            int a, b, c;
            Console.WriteLine("Enter 3 Numbers ");
            a=Convert.ToInt32(Console.ReadLine());
            b=Convert.ToInt32(Console.ReadLine());  
            c=Convert.ToInt32(Console.ReadLine());
            Max obj = new Max();
            obj.Maximum(a, b, c);

        }
    }
}
