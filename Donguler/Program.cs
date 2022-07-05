using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
          

           string[] kurslar = new string[] { "Yazılım geliştirme kampı", "Programlamaya başlangıç kursu", "Java kursu" };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("for bitti");

            foreach (string kurs in kurslar) //foreach dizilere uygulanır dizileir tek tek geziyor kursları
            {
                Console.WriteLine(kurs);
            }

                Console.WriteLine("footer sayfa sonu");
        }
    }
}
