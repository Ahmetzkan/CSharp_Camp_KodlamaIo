﻿using System;
using System.Collections.Generic;

namespace collections.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] {"engin","murat","kerem","halil" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);
            
            //Ctrl K + Ctrl C = Toplu Comment
            //Ctrl K + Ctrl U = Toplu UnComment
            
            //isimler = new string[5];
            //isimler[4] = "ilker";
            //Console.WriteLine(isimler[4]);
            // new string[5] derken new ettiğimiz için eski dizi gitti ve biz yenisini tanımladık.

            List<string> isimler2 = new List<string> {"Engin","Murat",
                "Kerem","Halil" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("İlker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);
            



        }
    }
}