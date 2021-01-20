
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "yazılımcı Geliştirme Kampı";
            string kurs2 = "Programlama için temel kurs";
            string kurs3 = "java";

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);



            string[] kurslar = new string[] { "yazılımcı Geliştirme Kampı", "Programlama için temel kurs", "java","c#","C" };
            //arrayler içerisinde birden fazla veri tutabilir tek tek 
            //girmektense array in içine atıp oradan çekme kdaha mantıklı 



            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("---Forech yapısı ile yapıldı-----");
            foreach (string kurs in kurslar)
            {
                
                Console.WriteLine(kurs);
            }




            Console.ReadLine();
            
        }
    }
}
