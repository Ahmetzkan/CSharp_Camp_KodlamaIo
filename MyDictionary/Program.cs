using System;

namespace MyDictionary
{
    //Aynen derste yaptığımız MyList gibi siz de kendi Dictonary sınıfınızı yazınız. (MyDictionary) Sadece ekleme (Add) metodunu yazınız.
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(06, "Ankara");
            myDictionary.Add(43, "Kütahya");
            myDictionary.Add(34, "İstanbul");
            myDictionary.Add(01,"Adana");
            Console.WriteLine(myDictionary.Length);
            for (int i = 0; i < myDictionary.Items.Length; i++)
            {
                Console.WriteLine(myDictionary.Items[i]+"    "+myDictionary.Items1[i]);
            }
        }
    }
}

