using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
           //decimal = 16 bytelik sayı tipleri içindir. En büyük yer kaplayandır.
           //byte = 0-255 değer aralığında int'e göre az yer kaplar.
           //long = Tc int de saklanmadığı için bunda saklanır.
           //char = Tek harf ve rakam için kullanılır.Tek tırnak içinde 'a'--'1'
           //double = kesirli sayılar için. 16 basamak 8 bayt lık.
           //float = 7 haneye kadar 4 baytlıktır. 

            //array,class,referance  Referans tiplerdir.
            //int,double vs değer tipleridir.



            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //Burada sayi1 = 30'dur

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };

            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //burada sayilar1[0] = 999'dur.


            
        }
    }
}
