// decimal kullanımı 

/* Decimal türündeki değişkenler 128 bitlik (16 byte) gerçek sayı depolarlar.
  decimal değişkeni tanımladığımızda eğer içerisine tam sayı olmayan bir değer 
  atamak istediğimizde sayısının sonuna M veya m koyarak türünün decimal olduğunu 
  belirtmemiz gerekmektedir. 
  Tamsayı olmayan sayılar için C# programlama dili floating point ve decimal olmak üzere iki ayrı alternatif sunar. 
  Decimal veri tipi diğer dillerde olmayan farklı bir veri tipidir.
   */
/* M (decimal veri tipleri için)
 * D (double veri tipleri için)
 * F (Float veri tipleri için)
 * L (Long veri tipleri için) */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example20_UseDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal price;
            decimal discount;
            decimal discounted_price;
            // indirimli fiyati hesapla
            price = 19.95m;
            discount = 0.15m; // indirim orani: %15
            discounted_price = price - (price * discount);
            Console.WriteLine("Discounted price: ${0: .##}", discounted_price);

            Console.ReadKey();
        }
    }
}

/* Ekran Çıktısı:
   Discounted price: $ 16,96
*/
