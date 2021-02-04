// 1'den 10'a kadar sayıların toplam ve çarpımlarını hesaplar (for döngüsü)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example17_ProdSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int prod, sum;

            sum = 0;
            prod = 1;

            for (int i = 1; i <= 10; i++)
            {   /* {...} Bir kod bloğunu gösterir. Kod bloğu sayesinde, toplam ve çarpımın her ikisinin tek bir döngü içinde
                hesaplanması mümkün oluyor. Blok kullanılmasaydı iki ayrı for döngüsü gerekecekti. */
                sum = sum + i;
                prod = prod * i;
            }

            Console.WriteLine("Sum is " + sum);
            Console.WriteLine("Product is " + prod);

            Console.ReadKey();
        }
    }
}


/* Ekran Çıktısı:
 * Sum is 55
 * Product is 3628800
*/
