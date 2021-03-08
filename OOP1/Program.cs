using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product {Id=2,CategoryId=5,UnitsInStock=5,
                ProductName="Kalem",UnitPrice=35  };

            //PascalCase= class ismi ilk harf büyük yazılır.
                           //camelCase = ilk küçük diğeri büyük yazılır.
            //case sensitive = küçük büyük harf duyarlılığıdır.
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);

            //int,double,bool... değer tip...anlık değer alıyor
            //diziler,class,abstract class,interface... referans tip... kalıcı değer alıyor.
            //return = döndür başka yerde de kullan anlamına gelir.
            //public void diye tanımlandığında üstüne console'a yazdırdığında işlem yapılıyor ve bitiyor.
            //fakat ben çıkan işlemi başka bir yerde daha kulllanmak istediğim için return ifadesini kullanıyorum ki başka yerde de kullanabileyim.

            //productManager.Topla2(3,6);
            
            //int toplamaSonucu = productManager.Topla(3, 6);

            //Console.WriteLine(toplamaSonucu*2);
        }

    }
}
