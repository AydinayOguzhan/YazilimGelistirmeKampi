using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kurslar = new string[] {"Yazılım Geliştirici Yetiştirme Kampı", "Programlamaya başlangıç için temel kurs", "Java" , "Python"};

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("");
            Console.WriteLine("For döngüsü sonu");
            Console.WriteLine("");
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
        }
    }
}
