using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training2
{
    internal class Loopex1
    {
        public void Show()
        {
            int i = 0; // Initialization
            int count = 10;
            while (i < count)
            {
                Console.WriteLine("Welcome to Dotnet...");
                i++;
            }
        }
        static void Main()
        {
            Loopex1 obj = new Loopex1();
            obj.Show();
        }
    }
}
