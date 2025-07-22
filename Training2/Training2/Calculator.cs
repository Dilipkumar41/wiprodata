using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

///<summary>
///arithmetic operations on 2 numbers
///User input is taken
///used methods for business logic
///calling methods in main method for result
///</summary>

namespace Training2
{
    internal class Calculator
    {
        public int Sum(int a,int b)
        {
            return a + b;
        }
        public int Sub(int a,int b)
        {
            return a - b;
        }
        public int Mul(int a,int b)
        {
            return a * b;
        }

        static void Main()
        {
            int a, b;
            Console.WriteLine("Enter 2 numbers");
            a=Convert.ToInt32(Console.ReadLine()); 
            b=Convert.ToInt32(Console.ReadLine());
            Calculator calculator = new Calculator();
            int result= calculator.Sum(a,b);
            Console.WriteLine("Sum is "+ result);
            result=calculator.Sub(a,b);
            Console.WriteLine("Sub is " + result);
            result = calculator.Mul(a,b);
            Console.WriteLine("Mul is " + result);

        }
        
        
    }
}
