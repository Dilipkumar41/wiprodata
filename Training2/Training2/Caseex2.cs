using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///<summary>
///creating a user input as choice
///writing method 
///creating object and retriving methods using object
///</summary>
namespace Training2
{
    internal class Caseex2
   
    {
        public void Check(string dayName)
        {
            switch (dayName.ToUpper())
            {
                case "SUN":
                    Console.WriteLine("TODAY IS SUNDAY");
                    break;
                case "MON":
                    Console.WriteLine("TODAY IS MONDAY");
                    break;
                case "TUE":
                    Console.WriteLine("TODAY IS TUESDAY");
                    break;
                case "WED":
                    Console.WriteLine("TODAY IS WEDNESDAY");
                    break;
                case "THU":
                    Console.WriteLine("TODAY IS THURSDAY");
                    break;
                case "FRI":
                    Console.WriteLine("TODAY IS FRIDAY");
                    break;
                case "SAT":
                    Console.WriteLine("TODAY IS SATURDAY");
                    break;
                default:
                    Console.WriteLine("INVALID CHOICE");
                    break;
            }
        }
        static void Main()
        {
            string dayName;
            Console.WriteLine("Enter first 3 characters od Day Name ");
            dayName=Console.ReadLine();
            Caseex2 caseex2 = new Caseex2();    
            caseex2.Check(dayName);

        }
    }
}
