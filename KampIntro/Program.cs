﻿using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategori";

            int ogrenciSayisi = 32000;
            double faizOrani = 10.5;
            bool sistemeGirisYapmisMi = false;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış butonu");
            }

            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış butonu");
            }

            else
            {
                Console.WriteLine("Değişmedi butonu");
            }


            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }

            else
            {
                Console.WriteLine(" Giriş yap butonu ");
            }


            
        }
    }
}
