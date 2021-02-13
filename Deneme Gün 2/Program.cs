using System;

public class Program
{
	public static void Main()
	{
        Urun urun1 = new Urun();
        urun1.urunboyu = 77;
        urun1.uruneni = 44;
        urun1.fiyatı = 24;

        Urun urun2 = new Urun();
        urun2.urunboyu = 67;
        urun2.uruneni = 34;
        urun2.fiyatı = 14;

        Urun[] urunler = new Urun();
        { urun1, urun2  };

        foreach (var urun in urunler)
            Console.WriteLine(urun.urunboyu);
    }

	class Kurs

	{
		public int urunboyu { get; set; }
		public int uruneni { get; set; }
		public int fiyatı { get; set; }

	}

}