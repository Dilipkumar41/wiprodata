using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractex
{
    internal class Hero2 : Hero
    {
        public override void count()
        {
            Console.WriteLine("total number of movies are 100+");
        }

        public override void Name()
        {
            Console.WriteLine("VIJAY THALAPATHY");
        }

        public override void Type()
        {
            Console.WriteLine("HE is from KOLLYWOOD");
        }
    }
}
