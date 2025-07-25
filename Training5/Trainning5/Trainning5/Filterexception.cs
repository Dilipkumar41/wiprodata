using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trainning5
{
    internal class Filterexception : ApplicationException
    {
        public Filterexception(string error) : base(error) { }
    }
}
