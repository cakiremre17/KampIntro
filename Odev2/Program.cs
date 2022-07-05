using System;

namespace Odev2
{
    class Program
    {
        static void Main(string[] args)
        {

            string adi = "Engin";
            int yas = 36;

            Urun urun1 = new Urun();
            urun1.UrunAdi = "Casio Saat";
            urun1.UrunFiyati = 50;
            urun1.UrunGrubu = "SAATLER";

            Urun urun2 = new Urun();
            urun2.UrunAdi = "Nike Ayakkabı";
            urun2.UrunFiyati = 150;
            urun2.UrunGrubu = "AYAKKABILAR";

            Urun urun3 = new Urun();
            urun3.UrunAdi = "Güneş Gözlüğü";
            urun3.UrunFiyati = 20;
            urun3.UrunGrubu = "GÖZLÜKLER";

            Urun[] urun = new Urun[] {urun1,urun2,urun3 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.UrunAdi + " : " + urun.UrunFiyati);
            }


            

        }
    }

    class Urun
    {
        public string UrunAdi { get; set; }
        public int UrunFiyati { get; set; }
        public string UrunGrubu { get; set; }
        
    }
}
