using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Extension1
{
    internal static class Append
    {
        public static int Mult(this Calculation calc,int a, int b)
        {
            return a*b;
        }
    }
}
