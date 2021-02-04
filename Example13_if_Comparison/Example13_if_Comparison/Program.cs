//if-else koşul döngüsü örneği

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example13_if_Comparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first integer: ");
            int number1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second integer: ");
            int number2 = int.Parse(Console.ReadLine());

            if (number1 == number2)
                //Console.Write($"{number1} = {number2}");
            Console.Write(number1 + " = " + number2);

            else if (number1 > number2)
                //Console.Write($"{number1} > {number2}");
            Console.Write(number1 + " > " + number2);

            else
               // Console.Write($"{number1} < {number2}");
            Console.Write(number1 + " < " + number2);

            Console.ReadKey();
        }
    }
}

/*Ekran Çıktısı:
 * Enter first integer: 3
 * Enter second integer: 4
 * 3 < 4
 */
