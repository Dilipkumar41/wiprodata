using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training2
{
    internal class Boxtest
    {
        public void Box(object obj)
        {
            String type = obj.GetType().Name;
            Console.WriteLine(type);
            if (type.Equals("Int32"))
            {
                int x = (Int32)obj;
                Console.WriteLine("Integer casting" + x);

            }
            if (type.Equals("String"))
            {
                String x= (String)obj;
                Console.WriteLine("string casting"+x);

            }
            if (type.Equals("Double"))
            {
                Double x= (Double)obj;
                Console.WriteLine("doubing casting" + x);

            }
        }
        static void Main()
        {
            int x = 12;
            String str = "Wipro";
            double y = 12.43;
            Boxtest data= new Boxtest();   
            data.Box(x);
            data.Box(y);
            data.Box(str);
        }
    }
}
