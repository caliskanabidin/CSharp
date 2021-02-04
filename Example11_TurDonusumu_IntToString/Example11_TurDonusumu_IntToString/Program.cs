using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example11_TurDonusumu_IntToString
{
	class Program
	{
		static void Main(string[] args)
		{
			int a = 8, b = 4;

			string a1 = a.ToString();
			string b1 = b.ToString();           
      
			Console.WriteLine("int a + b = " + (a + b)); // int value result
			Console.WriteLine("string a1 + b1 = " + (a1 + b1)); // string value result (string a1 ve b1'i yan yana yazar)

			// Console.WriteLine($"int a + b = {a + b}"); 
			// Console.WriteLine($"string a1 + b1 = {a1 + b1}"); 

			Console.ReadKey();
		}
	}
}
