using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example12_TurDonusumu_StringToInt32
{
	class Program
	{
		static void Main(string[] args)
		{
			string s1, s2;
			int sayi1, sayi2, toplam;

			Console.Write("1. Sayi: ");
			s1 = Console.ReadLine();

			Console.Write("2. Sayi: ");
			s2 = Console.ReadLine();

			sayi1 = Convert.ToInt32(s1);
			sayi2 = Convert.ToInt32(s2);

			Console.WriteLine($"Toplam (integer) = {sayi1 + sayi2}"); //integer olarak verilen toplam sonuç

			toplam = sayi1 + sayi2;
			Console.WriteLine("Toplam (string) = " + toplam.ToString()); //string'e dönüştürülmüş toplam

			Console.ReadKey();
		}
	}
}
