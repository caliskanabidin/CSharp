// for döngüsü ile faiz hesabı

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example16_for_interest_Account
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal principal = 1000m; // initial amount before interest
            double rate = 0.05d; // interest rate 5%

            Console.WriteLine("Year  Amount on deposit");

            for (int year = 1; year <= 10; year++) // 10-year interest account
            {
                decimal amount = principal * ((decimal)Math.Pow(1.0 + rate, year));

                Console.WriteLine($"{year,3}{amount,15:.###}"); // ,'den sonraki rakamlar soldan bırakılan boşluk karakter sayılarıdır. 

            }
            Console.Read();
        }
    }
}
