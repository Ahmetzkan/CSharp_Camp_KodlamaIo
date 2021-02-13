using System;

public class Program
{
	public static void Main()
	{
		Kurs kurs1 = new Kurs();
		kurs1.KursAdi = "C#";
		kurs1.Egitmen = "Ahmet Ozkan";
		kurs1.IzlenmeOrani = 65;

		Kurs kurs2 = new Kurs();
		kurs2.KursAdi = "Java";
		kurs2.Egitmen = "Ali Ozkan";
		kurs2.IzlenmeOrani = 625;

		Kurs kurs3 = new Kurs();
		kurs3.KursAdi = "Css";
		kurs3.Egitmen = "Osman Ozkan";
		kurs3.IzlenmeOrani = 64;

		//Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmen);
		Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

		foreach (var kurs in kurslar)
			Console.WriteLine(kurs.Egitmen);
	}

	class Kurs

	{
		public string KursAdi { get; set; }
		public string Egitmen { get; set; }
		public int IzlenmeOrani { get; set; }

	}

}