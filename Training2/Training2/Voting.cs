using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training2
{
    internal class Voting
    {
        public void Vote(int age)
        {
            if (age >= 18)
            {
                Console.WriteLine("eligible to vote");
            }
            else
            {
                Console.WriteLine("Not Eliginble to vote");
            }
        }
        static void Main()
        {
            int age;
            Console.WriteLine("Enter your age ");
            age=Convert.ToInt32(Console.ReadLine());  
            Voting obj = new Voting();  
            obj.Vote(age);

        }
    }
}
