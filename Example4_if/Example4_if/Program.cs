//if koşul ifadesi tanıtılıyor

using System;

namespace Example4_if
{
    class Program
    {
        static void Main()
        {
            int a=2, b=4, c, d;
            
            Console.WriteLine("a= " + a);
            Console.WriteLine("b= " + b);
            if (a < b) Console.WriteLine("a is less than b");
            if (a == b) Console.WriteLine("you won't see this");
            Console.WriteLine();

            c = a - b; 
            Console.WriteLine("c contains –2");
            if(c >= 0) Console.WriteLine("c is non-negative");
            if(c < 0) Console.WriteLine("c is negative");
            Console.WriteLine();

            d = b - a; 
            Console.WriteLine("d contains 2");
            if(d >= 0) Console.WriteLine( "d is non-negative");
            if(d < 0) Console.WriteLine("d is negative");
            Console.ReadKey();
        }
    }
}
/* Ekran çıktısı:
 * a= 2
 * b= 4
 * a is less than b
 * 
 * c contains -2
 * c is negative
 * 
 * d contains 2
 * d is non-negative
*/