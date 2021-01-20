using System;

namespace Kampİntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety:Tip güvenliği
            //do not repeat your self:Kendini Tekrarlama
            //değer tutucu (kategorietk)
            string kategorietk = "Kategori";
            int ogrencisayisi = 32000;
            double faiz = 1.45;//ondalıklı sayı
            bool sistemegirişyapmışmı = false;//bool:true yada false değer alır 
            double dolardun=7.35;
            double dolarbugun=7.45;

            if (dolardun>dolarbugun)
            {
                Console.WriteLine("Azalış Butonu");

            }
            else if (dolarbugun>dolardun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("eşit butonu");
            }

            Console.WriteLine(kategorietk);
            Console.WriteLine(ogrencisayisi);
            Console.WriteLine(faiz);
            Console.WriteLine(sistemegirişyapmışmı);



            if (sistemegirişyapmışmı==true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }

        }
    }
}
