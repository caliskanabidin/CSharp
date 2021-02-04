// for döngüsü ile 1-10 arası tek sayıların toplamı

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example7_for_sum
{
	class Program
	{
		static void Main(string[] args)
		{
			int total = 0;

			for (int i = 1; i <= 10; i += 2)
			{
				total += i;
			}
			//Console.WriteLine($"Sum is {total}");

			Console.WriteLine("\nSum is " + total); //display result

			Console.Read();
		}
	}
}
