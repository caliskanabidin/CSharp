// iki sayının toplamı

using System;

namespace Example6_Addition
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1, number2, sum, number3;

            Console.Write("Enter first number: ");
            number1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            number2 = int.Parse(Console.ReadLine());
			
			sum = number1 + number2;

            Console.WriteLine($"Sum is {sum}"); //display sum
            // Console.WriteLine("Sum is " + sum);

            Console.ReadKey(); 
        }
    }
}
/* Ekran Çıktısı:
 * Enter first number: 5
 * Enter second number: 2
 * Sum is 7
 */
