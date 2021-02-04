// 1'den 10'a kadar olan sayıları ekrana yazar

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example8_WhileCounter
{
	class Program
	{
		static void Main(string[] args)
		{
			int counter = 1;
			while (counter <= 10)
			{
				//Console.Write($"{counter} "); // satırlar aynı çıktıyı verir.
				//Console.Write("{0}",counter + " ");
				Console.WriteLine(" " + counter);
				counter++;
			}

			Console.ReadKey();
		}
	}
}
