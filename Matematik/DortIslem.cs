using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematik
{
    class DortIslem
    {
        public void Topla(int sayi1, int sayi2)
        {
            int toplam = sayi1 + sayi2;
            Console.WriteLine("Sonuç : "+toplam);
        }
        public void cikar(int sayi1, int sayi2)
        {
            int fark = sayi1 - sayi2;
            Console.WriteLine("Fark : "+fark);
        }
        public void bol(int sayi1, int sayi2)
        {
            int bol = sayi1 / sayi2;
            Console.WriteLine("Bölme Sonuç : " + bol);
        }
        public void carp(int sayi1, int sayi2)
        {
            int carp = sayi1 * sayi2;
            Console.WriteLine("Çarpım : " + carp);
        }
    }
}
