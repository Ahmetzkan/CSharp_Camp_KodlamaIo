using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {  //naming convetion = İsimlendirme Kuralı (İlk harfi büyük)
       //syntax = Yazım şekilleri
       //parametre = Durağan gibi görünen fakat yeni değerden sonra işlevi de değişen cebirsel simge vs... 
       //1.yol 
        public void Ekle(Urun urun) 
        {
            Console.WriteLine("Tebrikler.Sepete eklendi:" + urun.Adi);
        }
    
            // Hammal yolu 2.yol
            public void Ekle2(string urunAdi, string aciklama, double fiyat,int stokAdedi)

              {

            Console.WriteLine("Tebrikler.Sepete eklendi: " + urunAdi);
              }
    }
}
