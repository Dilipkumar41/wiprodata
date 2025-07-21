using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Employcustom
    {
        static void Main()
        {
            Employ emp1= new Employ();
            Employ emp2= new Employ();
            Console.WriteLine("Enter employe no, Name and Basic for first employee");
            emp1.empno = Convert.ToInt32(Console.ReadLine());
            emp1.name=Console.ReadLine();
            emp1.basic=Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter employe no, Name and Baic for second employe");
            emp2.empno = Convert.ToInt32(Console.ReadLine());   
            emp2.name=Console.ReadLine();  
            emp2.basic=Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("First Employe Data");
            Console.WriteLine("Empoye number " + emp1.empno);
            Console.WriteLine("Employe Name " + emp1.name);
            Console.WriteLine("Employe Basic " + emp1.basic);

            Console.WriteLine("Second Employe Data");
            Console.WriteLine("Empoye number " + emp2.empno);
            Console.WriteLine("Employe Name " + emp2.name);
            Console.WriteLine("Employe Basic " + emp2.basic);
        }
    }
}
