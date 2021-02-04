using System;

namespace Example12_Otomatik_tip
{
    class Program
    {
        static void Main()
        {
            int a;
            float b = 32.32f;
            double c;
            c = b;
            Console.WriteLine("b'nin değeri = " + b + "\nc'nin değeri = " + c);
        }
    }
}

/* Ekran Çıktısı
b 'nin değeri = 32.32
c 'nin değeri = 32.31999969482422
*/