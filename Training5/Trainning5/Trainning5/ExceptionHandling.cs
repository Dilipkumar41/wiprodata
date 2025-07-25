using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trainning5
{
    internal class ExceptionHandling
    {
       internal class Milestoneexception : ApplicationException 
        {
            public Milestoneexception(string message) : base(message) { }     
        }
        

        
    }
}
