using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training2
{
    internal class ArrayCopy
    {
        public void Copy()
        {
            int[] a= new int[] {13,56,75,4,3};
            int[] b = a;
            for (int i = 0;i<a.Length; i++)
            {
                Console.WriteLine(a[i]);
                Console.WriteLine(b[i]);
            }
        }
        static void Main()
        {
            ArrayCopy obj = new ArrayCopy();
            obj.Copy();
        }
    }
}
