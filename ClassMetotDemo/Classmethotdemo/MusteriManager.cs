using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {

        public void Add(Musteri müsteri)
        {
            Console.WriteLine(müsteri.Ad + " " + müsteri.Soyad + " kişisi eklendi.");
        }
        public void Delete(Musteri müsteri)
        {
            Console.WriteLine(müsteri.Ad + " " + müsteri.Soyad + " kişisi silindi.");
        }
        public void Listele(Musteri müsteri)
        {
            Console.WriteLine(müsteri.Ad + " " + müsteri.Soyad + " kişisi listelendi.");
        }


    }
}
