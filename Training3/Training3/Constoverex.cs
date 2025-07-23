using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training3
{
    internal class Constoverex
    {
        string name;
        int age;
        public Constoverex()
        {
            name = "unknown";
            age = 0;
        }
        public Constoverex(string studentname)
        {
            name=studentname;
            age = 0;
        }
       
        public Constoverex(string studentname, int studentage)
        {
            name= studentname;
            age= studentage;
        }
        public void Display()
        {
            Console.WriteLine("Student: "+name);
            Console.WriteLine("Age: " + age);
        }
        static void Main()
        {
            Constoverex constoverex1 = new Constoverex();
            constoverex1.Display();
            Console.WriteLine();
            Constoverex constoverex2 = new Constoverex("Dilip");
            constoverex2.Display();
            Console.WriteLine();
            Constoverex constoverex3 = new Constoverex("Dilip",22);   
            constoverex3.Display();

        }
    }
}
