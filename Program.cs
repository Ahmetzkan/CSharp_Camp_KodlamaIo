using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Ad = "Ahmet";
            musteri1.Soyad = "Özkan";
            musteri1.KimlikNumarasi = 12345;

            Musteri musteri2 = new Musteri();
            musteri2.Ad = "Ali";
            musteri2.Soyad = "Özkan";
            musteri2.KimlikNumarasi = 12335;

            Musteri musteri3 = new Musteri();
            musteri3.Ad = "Ayşe";
            musteri3.Soyad = "Özkan";
            musteri3.KimlikNumarasi = 12343;

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri1);
            musteriManager.Add(musteri2);
            musteriManager.Add(musteri3);

            Console.WriteLine("---------------------");

            musteriManager.Delete(musteri1);
            musteriManager.Delete(musteri2);
            musteriManager.Delete(musteri3);

            Console.WriteLine("---------------------");

            musteriManager.Listele(musteri1);
            musteriManager.Listele(musteri2);
            musteriManager.Listele(musteri3);







        }
    }
}
