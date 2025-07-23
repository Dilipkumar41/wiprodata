using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training3
{
    internal class Overload1
    {
        public void Show(int x)
        {
            Console.WriteLine("This is Show method w.r.t  int " +x);
        }
        public void Show(double x)
        {
            Console.WriteLine("this is Show method w.r.t double " + x);
        }
        public void Show(String x)
        {
            Console.WriteLine("this show method is w.r.t" + x);
        }
        static void Main()
        {
            Overload1 overload1 = new Overload1();
            overload1.Show(12);
            overload1.Show("wipro");
            overload1.Show(25.11);
        }
    }
}
