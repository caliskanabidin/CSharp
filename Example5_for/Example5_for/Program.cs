// for döngüsü tanıtılıyor

using System;

namespace Example5_for
{
    class fordongusu // Program.cs sınıfından farklı bir isim verilebilir. Java'da ise farklı isim verilemez.
    {
       public static void Main()
        {
            int count;

            for (count = 1; count <= 5; count++)
                Console.WriteLine("This is count: " +count);

            Console.WriteLine("Done!");

            Console.ReadKey();
        }
    }
}
/* Ekran Çıktısı:
 * This is count: 1
 * This is count: 2
 * This is count: 3
 * This is count: 4
 * This is count: 5
 * Done!
*/
