// Bu program değişkenleri tanıtıyor

using System;

namespace Example2
{
    class Program
    {
        public static void Main()
        {
            int x, y; //değşkenler deklare edilir
            double z=100;
            
            x = 100;
            y = x / 2;           
            Console.WriteLine("x contains " + x);
            Console.WriteLine(); // boş satır bırakır
            Console.WriteLine("y contains x/2 = " + y);
            Console.WriteLine(); 
            Console.WriteLine("Original value of z = " + z);
            z = z / 3.0;
            Console.WriteLine("z after division (z/3.0) = " + z);
            Console.WriteLine("z after division (z/3.0) = {0:.##}", z);
            Console.ReadKey(); // sonuç ekranını bir tuş basılana kadar açık bırakır. Console.Read() de yazılabilir.           
		}
    }
}

/*Ekran Çıktısı:
            * x contains 100
            * y contains x/2 = 50
            * Original value of z = 100
            * z after division (z/3.0) = 33,3333333333333
            * z after division (z/3.0) = 33,33
            */
