using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Training2
{
    internal class Milestoneex1
    {
        public void Vowels(string data)
        {
            data = data.ToLower();
            int Count = 0;
            char[] chars = data.ToCharArray();
            foreach (char c in chars)
            {
                if (c == 'a'|| c == 'e' || c == 'i' || c == 'o' || c == 'u')
                {
                    Count++;
                }
                Console.WriteLine("Vowels are "+Count);
            }
        }
        static void Main()
        {
            string data;
            Console.WriteLine("Enter any string");
            data = Console.ReadLine();
            Milestoneex1 obj=new Milestoneex1();
            obj.Vowels(data);
        }
    }
}
