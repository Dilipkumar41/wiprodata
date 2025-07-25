using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Bank
    {
        public int Acc { get; } = 1223;
        public string Accname { get; } = "Raju Dilip Kumar";
        public string Branch { get; } = "CTR";
    }
    internal class Readonly
    {
     
        static void Main(string[] args)
        {
            Bank bank = new Bank();
            Console.WriteLine("Account Number is "+bank.Acc);
            Console.WriteLine("Bank Holder Name "+bank.Accname);
            Console.WriteLine("Bank Branch Location "+bank.Branch);
        }
    }
}
