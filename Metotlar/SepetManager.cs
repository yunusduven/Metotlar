using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class SepetManager
    {
        public void Add(Product urun)
        {
            Console.WriteLine("Tebrikler Sepete Eklendi : "+" "+ urun.Adi + " " +urun.stokAdet);
        }
        
    }
}
