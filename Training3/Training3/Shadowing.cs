using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Training3
{
    class Student1
    {
        public void Show()
        {
            Console.WriteLine("hello first classs");

        }
    }
    class Student2 : Student1
    {
        public void Display()
        {
            base.Show();
            Console.WriteLine("hello secondclass");
        }

    }

    internal class Shadowing
    {
        static void Main()
        {

            Student2 student = new Student2();
            student.Display();

        }
    }
}
