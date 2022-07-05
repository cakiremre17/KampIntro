using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müsteri Eklendi : " + musteri.Ad + " " + musteri.Soyadi + " " + musteri.Yas);
        }

        
    }
}
