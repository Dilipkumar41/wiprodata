using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training2
{
    internal class CtoF
    {
        public double ConverttoFahrenehit(double celcius)
        {
            double f = ((9 * celcius) / 5) + 32;
            return f;
        }
        static void Main()
        {
            double celcius;
            Console.WriteLine("Enter celsius value");
            celcius=Convert.ToDouble(Console.ReadLine());
            CtoF obj=new CtoF();
            Console.WriteLine("fahrenheit value is " + obj.ConverttoFahrenehit(celcius ));

        }
    }
}
