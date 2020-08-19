using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeSixNine
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong a = ulong.Parse(Console.ReadLine());
            ulong b = ulong.Parse(Console.ReadLine());
            ulong c = ulong.Parse(Console.ReadLine());
            ulong r = 0;
            if (b == 3)
            {
                r = a + c;
            }
            else if (b == 6)
            {
                r = a * c;
            }
            else if (b == 9)
            {
                r = a % c;
            }
            ulong rr = 0;
            if (r % 3 == 0)
            {
                rr = r / 3;
            }
            else
            {
                rr = r % 3;
            }
            Console.WriteLine("{0}\n{1}", rr, r);
        }
    }
}
