using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Product urun1 = new Product();
            urun1.Adi = "Elma";
            urun1.Fiyat = 15;
            urun1.Aciklama = "Amasya Elması";
            urun1.stokAdet = 20;


            Product urun2 = new Product();
            urun2.Adi = "karpuz";
            urun2.Fiyat = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";
            urun2.stokAdet = 10;


            Product[] urunler = new Product[] { urun1, urun2 };
            foreach (Product urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyat);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine(urun.stokAdet);
                Console.WriteLine("----------------------------");

            }

            Console.WriteLine("--------Metotlar----------------");

            SepetManager sepetYonet = new SepetManager();
            sepetYonet.Add(urun1);
            sepetYonet.Add(urun2);

            Console.ReadLine();
        }
    }
}
