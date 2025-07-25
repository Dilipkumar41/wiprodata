using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trainning5
{
    internal class Filterexceptionex
    {
        static void RaiseSeverity(string severity)
        {
            if (severity.Equals("low"))
            {
                throw new Filterexception("low severity you can leave for time being...");
            }
            else if (severity.Equals("medium"))
            {
                throw new Filterexception("medium severity you need to try to fix without leaving...");
            }
            else if (severity.Equals("high"))
            {
                throw new Filterexception("high severity You need to fix on high priority...");
            }
            else if (severity.Equals("critical"))
            {
                throw new Filterexception("critical error as fix first as stop all other works...");
            }
            else
            {
                throw new Filterexception("No Error Occurred...");
            }
        }
        static void Main()
        {
            string severity;
            Console.WriteLine("Enter the Severity (low/medium/high/critical)  ");
            severity = Console.ReadLine();
            try
            {
                RaiseSeverity(severity);
            }
            catch (Filterexception e) when (e.Message.Contains("low"))
            {
                Console.WriteLine(e.Message);
            }
            catch (Filterexception e) when (e.Message.Contains("medium"))
            {
                Console.WriteLine(e.Message);
            }
            catch (Filterexception e) when (e.Message.Contains("high"))
            {
                Console.WriteLine(e.Message);
            }
            catch (Filterexception e) when (e.Message.Contains("critical"))
            {
                Console.WriteLine(e.Message);
            }
            catch (Filterexception e)
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
