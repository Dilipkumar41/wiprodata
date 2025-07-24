using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractex
{
    internal class Hero1 : Hero
    {
        public override void count()
        {
            Console.WriteLine("number of movies are 170 +");
        }

        public override void Name()
        {
            Console.WriteLine("MEGA STAR CHIRANJEEVI");
        }

        public override void Type()
        {
            Console.WriteLine("He is a TOLLYWOOD Hero");
        }
    }
}
