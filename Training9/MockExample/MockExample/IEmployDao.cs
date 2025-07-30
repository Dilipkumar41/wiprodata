using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockExample
{
    public interface IEmployDao
    {
        List<Employ> ShowEmploy();
        Employ SearchEmploy(int empno);
    }
}
