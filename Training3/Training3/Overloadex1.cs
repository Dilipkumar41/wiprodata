using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training3
{
    internal class Overloadex1
    {
        public void DisplayInfo(String name)
        {
            Console.WriteLine("Name: "+name);
        }
        public void DisplayInfo(string name,int age)
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);

        }
        public void DisplayInfo(String name, int age, String city)
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("City: " + city);
        }
        static void Main()
        {
            Overloadex1 overloadex1 = new Overloadex1();
            overloadex1.DisplayInfo("Wipro AzeemPremji");
            Console.WriteLine();

            overloadex1.DisplayInfo("Dilip kumar", 22);
            Console.WriteLine();
            overloadex1.DisplayInfo("Pooja", 25, "Chittoor");

        }
    }
}
