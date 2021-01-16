using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        public void Ekle(Urunler urun)
        {
            Console.WriteLine("Sepete eklendi: " + urun.Adi);
        }
        
    }
}
