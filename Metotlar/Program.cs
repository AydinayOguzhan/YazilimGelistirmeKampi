using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urunler urun1 = new Urunler();
            urun1.Adi = "Elma";
            urun1.Fiyat = 15;
            urun1.Aciklama = "Amasya Elması";

            Urunler urun2 = new Urunler();
            urun2.Adi = "Karpuz";
            urun2.Fiyat = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urunler[] urunler = new Urunler[] { urun1, urun2 };

            foreach (var item in urunler)
            {
                Console.WriteLine(item.Adi);
                Console.WriteLine(item.Fiyat);
                Console.WriteLine(item.Aciklama);
                Console.WriteLine("-------------------------");
            }

            Console.WriteLine("------------------Metotlar-----------------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
                
        }
    }
}
