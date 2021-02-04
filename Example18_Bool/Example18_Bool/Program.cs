// bool değerlerini gösteren bir örnek.
/*bool tipi doğru/yanlış değerlerini simgeler. C#'ta doğru ve yanlış değerleri true ve
false özel amaçlı kelimeleriyle tanımlanır. Yani, bool tipinde bir değişken veya deyim bu iki
değerden birine eşit olabilir.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example18_Bool
{
    class Program
    {
        static void Main(string[] args)
        {
            bool b; // bool tipi doğru/yanlış değerlerini simgeler. 
            b = false;
            Console.WriteLine("b is " + b);
            b = true;
            Console.WriteLine("b is " + b);
            // bir bool degeri, if ifadesini kontrol edebilir
            if (b) Console.WriteLine("This is executed.");
            b = false;
            if (b) Console.WriteLine("This is not executed.");
            // ilişkisel operatorun sonucu bir bool degerdir
            Console.WriteLine("10 > 9 is " + (10 > 9));
            // Bir ilişkisel operatörün, örneğin > veya < operatörünün çıktısı bir bool değerdir.
            // 10 > 9 deyiminin ekranda "True" değerini göstermesi bu sebeptendir. 
            Console.WriteLine("4 < 2 is " + (4 < 2));

            Console.ReadKey();
        }
    }
}

/* Bu programın ürettiği çıktı :
      b is False
      b is True
      This is executed.
      10 > 9 is True
      4 < 2 is False
*/
