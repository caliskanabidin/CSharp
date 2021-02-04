// break statement

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example9_for_if_break
{
	class Program
	{
		static void Main(string[] args)
		{
			int count;

			for (count = 1; count <= 10; count++) //loop 10 times
			{
				if (count == 5)
				{
					break; // terminate loop
						   //continue; //skip remaining code in lope
				}
				Console.WriteLine(" " + count);
			}
			Console.WriteLine("Broke out of loop at count = " + count);

			Console.ReadKey();
		}
	}
}
