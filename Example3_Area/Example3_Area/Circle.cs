//Bir dairenin alanını hesaplar

using System;

namespace Example3_Area
{
    class Circle
    {
        static void Main()
        {
            double radius, area, pi_degeri;

            pi_degeri = 3.1416;

            radius = 5.0;

            area = pi_degeri * radius * radius;

            Console.WriteLine("Area is = " + area);
            
            Console.ReadKey();
        }
    }
}

/*Ekran Çıktısı:
 * Area is = 78,54 */
