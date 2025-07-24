using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces2
{
    internal class Demo : ICompany, ICompany2
    {
        void ICompany.Show()
        {
            Console.WriteLine("Company name is Wipro");

        }
        void ICompany2.Show()
        {
            Console.WriteLine("Employes are moe than lakhs");
        }
    }
}
