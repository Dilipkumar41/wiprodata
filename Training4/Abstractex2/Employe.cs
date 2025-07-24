using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractex2
{
    internal abstract class Employe
    {
        private String name;
        private int id;
        private double basic;

        public Employe(String name, int id, double basic)
        {
            this.name = name;
            this.id = id;
            this.basic = basic;
        }

        public override String ToString()
        {
            return "Employe Name " + this.name + "Employe Id" + this.id + "Employee Basic" + this.basic;

        }
       
    }
}
