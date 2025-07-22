using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///<summary>
///taking user input as a choice
///writing methods
///accessing method using object
///</summary>

namespace Training2
{
    internal class Caseex1
    {
        public void check(char choice)
        {
            switch(choice)
            {
                case 'a':
                case 'A':
                case '1':
                    Console.WriteLine("Hii im Dilip");
                    break;
                case 'b':
                case 'B':
                case '2':
                    Console.WriteLine("this wipro training");
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
        static void Main()
        {
            char choice;
            Console.WriteLine("Enter your choice");
            choice =Convert.ToChar(Console.ReadLine()); 
            Caseex1 caseex1 = new Caseex1();
            caseex1.check(choice);

        }
    }
}
