using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trainning5
{
    internal class FilterException1_1
    {
        static void FilterData(string name)
        {
            string filter = "";

            if (name.Length >= 0 && name.Length <= 3)
            {
                filter = "small";
            }
            else if (name.Length > 3 && name.Length <= 10)
            {
                filter = "medium";
            }
            else if (name.Length > 10)
            {
                filter = "good";
            }
            if (filter == "small")
            {
                throw new Filterexceptionex1("small name exception occured");
            }
            else if (filter == "medium")
            {
                throw new Filterexceptionex1("medium name exception occurred");
            }
            else if (filter == "good")
            {
                throw new Filterexceptionex1("good its not an exception...");
            }
            else
            {
                throw new Filterexceptionex1("This Case Not Defined...");
            }
        }
        static void Main()
        {
            string name;
            Console.WriteLine("Enter Name  ");
            name = Console.ReadLine();

            try
            {
                FilterData(name);
            }
            catch (Filterexceptionex1 e) when (e.Message.Contains("small"))
            {
                Console.WriteLine(e.Message);
            }
            catch (Filterexceptionex1 e) when (e.Message.Contains("medium"))
            {
                Console.WriteLine(e.Message);
            }
            catch (Filterexceptionex1 e) when (e.Message.Contains("good"))
            {
                Console.WriteLine(e.Message);
            }
            catch (Filterexceptionex1 e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
