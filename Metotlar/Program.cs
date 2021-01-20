using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();//classın Örneği
            urun1.Adi = "Elma";
            urun1.Fiyat = 15;
            urun1.Aciklama = "Amasya Elması";
            urun1.StokAdedi = 5;
            

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyat = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";
            urun2.StokAdedi = 12;
            Urun[] array = new Urun[] {urun1,urun2 };


            foreach (Urun item in array)//array içindeki elemanları tek tek gez ve al
            {
                Console.WriteLine(item.Adi);
                Console.WriteLine(item.Fiyat);
                Console.WriteLine(item.Aciklama);
            }
            Console.WriteLine("----------Metotlar--------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);//ekle fonksiyonunu çağırdık
            sepetManager.Ekle(urun2);//bu fonksiyonu başka başka yerlerde çağırabiliriz

            Console.WriteLine("-----------Ayırac---------");

            sepetManager.Ekle2("Armut", "Yeşil Armut", 12,5);
            sepetManager.Ekle2("Kiraz", "Salkım Salkım Kiraz", 15,12);

        }
    }
}
