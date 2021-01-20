using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //naming convention
        //syntax
        public void Ekle(Urun urun)
        {
            Console.WriteLine(" Tebrikler Sepete Eklendi! : "+urun.Adi);
            Console.WriteLine("Stokda " + urun.StokAdedi + " tane var.");
        }
        public void Ekle2(string urunAdi,string aciklama,double fiyat,int stokAdedi)
        {

            Console.WriteLine(" Tebrikler Sepete Eklendi! : " +urunAdi);
        }


    }
}
