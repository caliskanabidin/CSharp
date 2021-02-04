/*
Bu bir C# programıdır.
Bu programa program.cs adı verildi.
*/
// Bir C# programı Main()‘e çağrıda bulunarak başlar.

using System; // System isim uzayı kullanılıyor

namespace Example1
{
    class Program
    {
        public static void Main()
		/* Bu satır Main() metodu ile başlıyor. C#'ta alt rutinler metot
        olarak adlandırılır. Main(), programın çalışmaya başlayacağı satırdır. C# uygulamalarının 
        tümü Main()'i çağırarak çalışmaya başlarlar. */
		/* Bir sınıf üyesinin öncesinde public yer alıyorsa bu üye, deklare edildiği sınıfın dışında kalan
        kod tarafından erişilebilir. (public'in karşıtı private'dır. private, bir üyenin tanımlı
        olduğu sınıfın dışındaki kod tarafından kullanılmasını önler.) 
        Bu örnekte Main(), public olarak deklare edilmektedir, çünkü Main(), program çalıştığında kendisinin ait olduğu sınıf
        dışındaki kod (yani, işletim sistemi) tarafından çağrılacaktır. */
		// Main ()'in ardından gelen boş parantezler, Main'e hiçbir bilgi aktarılmadığını gösteriyor.
		/*Sistem main() fonksiyonundan çalışmaya başlar. Void bu fonksyonun tipidir. 
		Herhangi bir şey geri döndürmeden sonlanabilicegini ifade eder. 
		Parantez içerisine string[] args yazıldığında ise bu fonksiyonun alabileceği parametreleri belirtilmiş olur. */

		{
			string name1 = "Faculty of Engineering and Architecture"; 
            string name2 = "Computer Engineering Department";

            //System.Console.Out.WriteLine("Hello World!\n");  // Programın başında 'using System' yazıldığı için System uzayını tekrar yazmaya gerek yok.
            Console.Out.Write("Hello World!\n");
            Console.WriteLine("Hello World!"); //'Line' ile imleç alt satıra geçer.
            //WriteLine()'ın Console sınıfının bir üyesi olduğu derleyiciye bildiriliyor.
            Console.Write( name1 + " - " + name2 ); //Birden çok string yazdırmak için aralarına '+' konulur.
            Console.ReadLine();    
        }
    }
}

/*Ekran Çıktısı:
            * Hello World!
            * Hello World!
            * Faculty of Engineering and Architecture - Computer Engineering Department */
