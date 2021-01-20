using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassIntro
{
   
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1=new Kurs();
            kurs1.Kursadi = "C#";
            kurs1.egitmen = "Engin Demiroğ";
            kurs1.Izlenmeoran = 68;
            Console.WriteLine();

            Kurs kurs2 = new Kurs();
            kurs2.Kursadi = "Java";
            kurs2.egitmen = "Muhammet Yılmaz";
            kurs2.Izlenmeoran = 80;

            Kurs kurs3 = new Kurs();
            kurs3.Kursadi = "C++";
            kurs3.egitmen = "Enes Kara";
            kurs3.Izlenmeoran = 100;

            //Console.WriteLine("Programlama:" + kurs1.Kursadi + " Eğitmeni:" + kurs1.egitmen + "İzlenme Oranı:" + kurs1.Izlenmeoran);
            //Console.WriteLine("Programlama:" + kurs2.Kursadi + " Eğitmeni:" + kurs2.egitmen + "İzlenme Oranı:" + kurs2.Izlenmeoran);

            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3 };//Kurs arrayinde kurs1 ve kurs 2 verilerini tutuyoruz
            foreach (Kurs icerik  in kurslar)
            {
                Console.WriteLine(icerik.Kursadi+" <---> "+icerik.egitmen);//Kursadları getirecek
            }

            Console.ReadKey();
        }
    }
     class Kurs
    {
        public string Kursadi { get; set; }
        public string egitmen { get; set; }
        public int Izlenmeoran { get; set; }
    }
}
