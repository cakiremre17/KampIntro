using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Emre Çakır
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Emre";
            musteri1.Soyadi = "Çakır";
            musteri1.TcNo = "21980448841";

            //Crown Şirket

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Crown AŞ";
            musteri2.VergiNo = "9876543";

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);



        }
    }
}
