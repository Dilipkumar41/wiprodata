using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcepHandling
{
	internal class ArrayExcep
	{
		static void Main()
		{
			int[] a = new int[] { 2, 5 };
			try
			{
				a[10] = 255;
			}
			catch (IndexOutOfRangeException e)
			{
                Console.WriteLine("Array size is too small...");
			}

			catch (Exception e)
			{
				Console.WriteLine(e);
			}
		}
	}
}

