using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList <T>
    {
        T[] items;
        //constructor = kurucu
        //Yukardaki T[] items;(eleman) dizisi public içinde new lenmesi için xpublic dışında class içinde tamamladık.
        //+Void, geriye değer döndürmeyen metotları belirtmek için kullanılır.
        //+Public, Protected ve Private tanımlamalarına ise erişim belirleyiciler(Access Modifiers) denir. 
        //+Public olarak tanımlanan öğeye kod bloğunun içinden ve dışından erişebilir, yani her yerden ulaşılabilir denilebilir.
        //+Statik tanımlaması yapıldığında ise bu sınıfa herhangi bir nesne oluşturmadan, sadece adıyla çağırıp erişim sağlanabilir.
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items;
            items = new T[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;

        }

        // yukarda 0 elemanlı olarak tanımladık aşağısında ise add işleminden sonra items.length yani items elemanı kadara +1 ekle dedik.
        //temparray ile de kaybolmasın diye adresini değiştirdik.


        public int Length
        {
            get { return items.Length; }
        }

        public T[] Items
        {
            get { return items; }
        }


    }
}
