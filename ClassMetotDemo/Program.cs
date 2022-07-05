using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Musteri musteri1 = new Musteri();
            musteri1.Ad = "Emre";
            musteri1.Soyadi = "Cakir";
            musteri1.Boy = 185;
            musteri1.Yas = 24;

            Musteri musteri2 = new Musteri();
            musteri2.Ad = "Eren";
            musteri2.Soyadi = "Cakir";
            musteri2.Boy = 175;
            musteri2.Yas = 19;

            Musteri musteri3 = new Musteri();
            musteri3.Ad = "Ebru";
            musteri3.Soyadi = "Cakir";
            musteri3.Boy = 170;
            musteri3.Yas = 21;

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);




        }
    }
}
