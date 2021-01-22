using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematik
{
    class Program
    {
        static void Main(string[] args)
        {
            DortIslem dortIslem = new DortIslem();
            dortIslem.Topla(2, 3);
            dortIslem.bol(10, 2);
            dortIslem.cikar(10 ,4);
            dortIslem.carp(2, 2);

            Console.ReadLine();
        }
       
    }
}
