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

            Console.WriteLine(s);
            Console.WriteLine(h);
            Console.WriteLine(d);
            Console.ReadKey();
        }
    }
}
