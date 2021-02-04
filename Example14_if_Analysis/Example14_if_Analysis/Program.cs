// Sınavdan geçen ve kalan öğrenci sayısını while ve if-else ile hesaplama

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example14_if_Analysis
{
    class Program
    {
        static void Main(string[] args)
        {
            int passes = 0, failures = 0, studentCounter = 1;

            while (studentCounter <= 5)
            {
                Console.Write("Enter result (1 = pass, 0 = fail): ");
                int result = int.Parse(Console.ReadLine());
                if (result == 1)
                {
                    passes += 1;
                }
                else
                {
                    failures += 1;
                }
                studentCounter++;
            }

            Console.WriteLine($"Number of students passed the exam: {passes}" +
                $"\nNumber of students failed the exam: {failures}");

            if (passes > 3)
            {
                Console.WriteLine("Bonus to instructor!");
            }

            Console.ReadKey();
        }
    }
}


/* Ekran Çıktısı:
 * Enter result (1 = pass, 0 = fail): 1
 * Enter result (1 = pass, 0 = fail): 0
 * Enter result (1 = pass, 0 = fail): 1
 * Enter result (1 = pass, 0 = fail): 1
 * Enter result (1 = pass, 0 = fail): 1
 * Number of students passed the exam: 4
 * Number of students failed the exam: 1
 * Bonus to instructor!
*/
