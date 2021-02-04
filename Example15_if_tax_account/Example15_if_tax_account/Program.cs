//Vergi hesabı yapan uygulama
//if, else if, for, while ve break konuları.
//negatif bir değer girildiğinde döngü sonlanacak.

/* gelir<=1000 ise %10 vergi
 * 1000<gelir<=10000 ise %20 vergi
 * gelir>10000 ise %30 vergi */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example15_if_tax_account
{
    class Program
    {
        static void Main(string[] args)
        {
            //int gelir;      
            double vergi = 0.0, toplamVergi = 0.0;

            //for(int i=1;i<=3;i++)
            int i = 1;
            while (true) // negatif (if(gelir<0)) bir değer girildiğinde döngü sonlanır.
            {
                Console.Write(i + ". kişinin gelirinizi giriniz: ");
                int gelir = int.Parse(Console.ReadLine());
                /* string okunan = Console.ReadLine(); //farklı tanımlama biçimidir. 
                 gelir = int.Parse(okunan); */

                if (gelir < 0)
                {
                    break;
                }

                if (gelir <= 1000)
                {
                    vergi = (double)gelir * 0.1;
                }

                else if (gelir > 1000 && gelir <= 10000)
                {
                    vergi = (double)gelir * 0.2;
                }

                else
                {
                    vergi = (double)gelir * 0.3;
                }

                toplamVergi += vergi;

                Console.WriteLine(i + ". kisinin vergisi: " + vergi);
                i++;


            }

            Console.WriteLine("\nToplam vergi= " + toplamVergi + "\nOrtalama vergi= "
                + toplamVergi / (i - 1)); //çıkış işleminde girilen son değer için 1 eksiltme yapılır.

            Console.Read();
        }
    }
}
