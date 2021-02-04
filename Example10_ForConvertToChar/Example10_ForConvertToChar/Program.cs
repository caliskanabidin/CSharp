using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example10_ForConvertToChar
{
	class Program
	{
		static void Main(string[] args)
		{
			char ch;

			Console.Write("Enter a charter (for quit 'q'): ");
            

            for (ch = Convert.ToChar(Console.ReadLine()); ch != 'q' ; ch = Convert.ToChar(Console.ReadLine()))
				//Bu dögü kullanıcıdan sürekli karakter alır. Kullanıcı 'q' karakterini girince döngü sonlanır.

			Console.WriteLine("Charter is: " + ch);
            Console.WriteLine();
           
        }
	}
}
