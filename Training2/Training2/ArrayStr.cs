using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training2
{
    internal class ArrayStr
    {
        public void Str()
        {
            string[] names = new string[]
            {
                "Raju","Dilip","Afrin","Pooja"
            };
            foreach(string name in names)
            {
                Console.WriteLine(name);
            }
        }
        static void Main()
        {
            ArrayStr obj=new ArrayStr();
            obj.Str();
        }
    }
}
