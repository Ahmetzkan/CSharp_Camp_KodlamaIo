using System;
class MainClass
{
    public static void Main(string[] args)
    {
        string kategoriEtiketi = "Kategori";
        int OgrenciSayisi = 32000;
        double FaizOrani = 1.45;
        bool SistemeGirisYapmismi = true;
        double DolarDun = 7.35;
        double DolarBugun = 7.45;

        if (DolarDun > DolarBugun)
        {
            Console.WriteLine("Azalış Butonu");

        }

        else if (DolarDun < DolarBugun)

        {
            Console.WriteLine("Artış Butonu");

        }

        else

        {

            Console.WriteLine("Değişmedi Butonu");
        }


        if (SistemeGirisYapmismi == true)
        {
            Console.WriteLine("Kullanıcı Ayarlar butonu");

        }
        else
        {
            Console.WriteLine("Giriş yap butonu");

        }



        Console.WriteLine(kategoriEtiketi);

        //string= Veri tutucu,değişken
        //int= Tam sayı tutmak için
        //double= Ondalıklı sayılar için  
        //bool= Doğru ve yanlış onaylama aracı
        //if()= --> şart geçerliyse {} --> bunu yap
        //if yazdıktan sonra iki tab yaparsan otomatik açar
        // i=i+2  
    }
}