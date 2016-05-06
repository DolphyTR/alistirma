using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bolen_bul
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Tam bölümü hesaplanıcak sayıyı giriniz: ");
            //kullanıcıdan sayımızı alalım
            int sayi = Convert.ToInt32(Console.ReadLine());
            
            //1 den girilen sayıya kadar artan bir döngü kuralım
            //saymaya 0 dan başlamadık çünki 0 a bölme işlemi tanımsız olduğu için hata ile karşılaşıcaktık.
            for(int i = 1; i < sayi; i++)
            {
                //girilen sayının artan i değeri ile bölümünden kalanını bulmak için mod aldık.
                //mod almak % işareti ile yapılır ve mod işaretinin solundaki değeri sağındaki değere bölüp kalanı verir.
                //eğer kalan sıfır ise tam bölünmüş olucaktır
                if(sayi % i == 0)
                {
                    //kalanın sıfır ise girilen sayi bölü döngüdeki değer tam olarak bölünmüştür olarak ekrana çıktı veriyoruz.
                    Console.WriteLine(sayi + "/" + i + " Tam Bölündü");
                }
            }

            //programımızın hemen sonlanmaması için klavye girişi bekletiyoruz.
            Console.ReadKey();
        }
    }
}
