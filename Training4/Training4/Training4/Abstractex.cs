using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training4
{
    internal class Abstractex
    {
        static void Main(string[] args)
        {
            Training[] arrTraining = new Training[]
            {
                new Dilip(),
                new Afrin()
            };
            foreach(Training t in arrTraining)
            {
                t.Company();
                t.Name();
                t.Email();
            }
        }
    }
}
