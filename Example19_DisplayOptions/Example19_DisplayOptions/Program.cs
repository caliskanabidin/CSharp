// Biçimlendirme komutları {}
/* Programın çalışması sırasında, biçimlendirme karakter katarı içinde bir biçimlendirme
belirleyicisine rastlanınca, argno'ya karşılık gelen argüman argno'nun yerine yerleştirilir ve
ekranda gösterilir.Yani argno, eşlenecek verinin nerede gösterileceğini belirleyen,
biçimlendirme karakter katarının içindeki biçimlendirme spesifikasyonunun konumudur. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example19_DisplayOptions
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("February has {0} or {1} days.\n", 28, 29);
            //Örneğin {0}, arg0'ı gösterir,{1} arg1'i gösterir
            //Görüldüğü gibi, {0} için 28 ve {1} için de 29 değeri yerine yerleştiriliyor. 
            //Ayrıca, ekstra değerler + işareti ile değil, virgül ile ayrılıyor.
            //Çıktı: February has 28 or 29 days.

            Console.WriteLine("Value\tSquared\tCubed");
            for (i = 0; i < 10; i++)
                Console.WriteLine("{0}\t{1}\t{2}", i, i * i, i * i * i);
            Console.WriteLine();
            Console.WriteLine("Here is 10/3:{0: .##} and 5/3:{1: .##}", 10.0 / 3.0, 5.0 / 3.0);
            /* Bu örnekle şablon, WriteLine()'a iki ondalık basamak ayırmasını söyleyen  .##
            karakterleridir. */
            Console.ReadKey();
        }
    }
}

/* Ekran Çıktısı:
 * February has 28 or 29 days.

Value   Squared Cubed
0       0       0
1       1       1
2       4       8
3       9       27
4       16      64
5       25      125
6       36      216
7       49      343
8       64      512
9       81      729

Here is 10/3: 3,33 and 5/3: 1,67
*/
