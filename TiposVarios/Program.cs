using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposVarios
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Unicode \u0b80";
            string h = "Copyright \u0ce0";
            string d = "Unicode \x0040";
            string p = "a" + 6;
            string i = "bbb" + 9;
            string z = $"valor de z e´ {9}";


            Console.WriteLine(s);
            Console.WriteLine(h);
            Console.WriteLine(d);
            Console.WriteLine(p);
            Console.WriteLine(i);
            Console.WriteLine(z);
            Console.ReadKey();
        }
    }
}
