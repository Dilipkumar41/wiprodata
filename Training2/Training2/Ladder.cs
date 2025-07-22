using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training2
{
    internal class Ladder
    {
        public void check(int choice)
        {
            if (choice == 1)
            {
                Console.WriteLine("Hi Im a robotic Engineer");
            }
            else if (choice == 2)
            {
                Console.WriteLine("Hi Im a software Engineer");
            }
            else if (choice == 3)
            {
                Console.WriteLine("Hi Im a Mechanical Engineer");
            }
            else if (choice == 4)
            {
                Console.WriteLine("Hi Im a Civil Engineer");
            }
            else if (choice == 5)
            {
                Console.WriteLine("Hi Im a Electrical Engineer");
            }
            else
            {
                Console.WriteLine("Choice is not defined");
            }
        }
        static void Main()
        {
            int choice;
            Console.WriteLine("Enter your choice ");
            choice = Convert.ToInt32((string) Console.ReadLine());  
            Ladder obj= new Ladder();   
            obj.check(choice);
        }
    }
}
