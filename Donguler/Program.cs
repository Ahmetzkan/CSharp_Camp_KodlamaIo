using System;

public class Program
{
	public static void Main()
	{
		//array = dizi
		//kurslar.Length ---> "Length" komutu kurslar listesinin içindeki elemana kadar döngünün ilerlemesini sağlar"
		//Java da stringlerin "S" si büyük yazılır. Yazdırma işlemi de System.out.Printline şeklindedir"
		//foreach (string kurs in kurslar);  "foreach kursları dolaşır ve uygular"
		//  i=i+2 
		//  i+=2
		string[] kurslar = new string[] { "Yazılım kampı", "Java", "C#", "Python", "Javascript" };

		for (int i = 0; i < kurslar.Length; i++)
		{
			Console.WriteLine(kurslar[i]);

		}
		Console.WriteLine("---FOR BİTTİ!---");
		foreach (string kurs in kurslar)
		{
			Console.WriteLine(kurs);
		}

		{
			Console.WriteLine("sayfa sonu - footer");
		}

	}
}