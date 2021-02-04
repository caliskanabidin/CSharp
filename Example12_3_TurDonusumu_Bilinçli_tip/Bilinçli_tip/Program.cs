using System;

namespace Bilinçli_tip
{
    class Program
    {
        static void Main(string[] args)
        {
            double d1, d2; int i; byte b; char c; uint u; short s; d1 = 5.0; d2 = 4.0;

            //double int e dönüştü veri kaybı var, virgülden sonrası atılır.
            i = (int)(d1 / d2); Console.WriteLine("Double integere çevrildi=" + i); Console.WriteLine();

            //int'i byte dönüştür, Veri kaybı yok.
            i = 123; b = (byte)i; Console.WriteLine("i'nin değeri=" + i + " iken b'nin değeri=" + b);

            //Veri kaybı var.
            i = 258; b = (byte)i; Console.WriteLine("i'nin değeri=" + i + " iken b'nin değeri=" + b);

            Console.WriteLine();

            //uint'i short'a dönüştür. Veri kaybı yok.
            u = 32146; s = (short)u;  

            Console.WriteLine("u'nun değeri=" + u + " iken s'nin değeri=" + s);

            u = 35000; s = (short)u; //Veri kaybı var.

            Console.WriteLine("u'nun değeri=" + u + " iken s'nin değeri=" + s); Console.WriteLine();

            //int'i char'a dönüştür.
            i = 90; c = (char)i; Console.WriteLine(i + " sayısını char'a dönüştürürsek = " + c + " olur");
            i = 80; c = (char)i; Console.WriteLine(i + " sayısını char'a dönüştürürsek = " + c + " olur");
            i = 70; c = (char)i; Console.WriteLine(i + " sayısını char'a dönüştürürsek = " + c + " olur");
            i = 60; c = (char)i; Console.WriteLine(i + " sayısını char'a dönüştürürsek = " + c + " olur");
            i = 50; c = (char)i; Console.WriteLine(i + " sayısını char'a dönüştürürsek = " + c + " olur");
            i = 45; c = (char)i; Console.WriteLine(i + " sayısını char'a dönüştürürsek = " + c + " olur");
        }
    }
}

/* Ekran Çıktısı
Double integere çevrildi=1

i'nin değeri=123 iken b'nin değeri=123
i'nin değeri=258 iken b'nin değeri=2

u'nun değeri=32146 iken s'nin değeri=32146
u'nun değeri=35000 iken s'nin değeri=-30536

90 sayısını char'a dönüştürürsek = Z olur
 */