using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///<summary>
///creating main method to find area and circumference of circle
///deriving user input
///creating method for business logic
///creating object to access method for the result
///</summary>
namespace Training2
{
   
    internal class Circle
    {
        public void Calc(double radius)
        {
            double area, cir;
            area = Math.PI * radius * radius;
            cir = 2 * Math.PI * radius;
            Console.WriteLine("area of circle " + area);
            Console.WriteLine("circumference of circle " + cir);


        }
        static void Main()
        {
            double radius;
            Console.WriteLine("enter radius");
            radius=Convert.ToDouble(Console.ReadLine());
            Circle circle = new Circle();  
            circle.Calc(radius);
        }
    }
}
