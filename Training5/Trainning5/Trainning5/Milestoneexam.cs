using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Trainning5.ExceptionHandling;

namespace Trainning5
{
    internal class Milestoneexam
    {
        static void Showmilestoneinfo(string examcode)
        {
            if (examcode.Equals("m1"))
            {
                throw new Milestoneexception("Milestone1 contins core concepts of .net");


            } else if (examcode.Equals("m2"))
            {
                throw new Milestoneexception("Milestone2 contains asp.net");
            }else if (examcode.Equals("m3"))
            {
                throw new Milestoneexception("Milestone 3 has various .net languages");
            }
            else
            {
                throw new Milestoneexception("No Error occcured");
            }
        }

        static void Main()
        {
            string examcode;
            Console.WriteLine("Enter exam code (m1,m2,m3)");
            examcode=Console.ReadLine();
            try
            {
                Showmilestoneinfo(examcode);
            }
            catch(Milestoneexception e) when (e.Message.Contains("Milestone1"))
            {
                Console.WriteLine(e.Message);
            }

            catch(Milestoneexception e) when (e.Message.Contains("Milestone1"))
            {
                Console.WriteLine(e.Message);
            }
            catch(Milestoneexception e) when (e.Message.Contains("Milestone2")){
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {

                Console.WriteLine(e);
            }
        }

      
    }
}
