using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitwiseExactBit
{
    class Program
    {
        static void Main(string[] args)
        {
            int position = 3;
            Console.WriteLine("Please input a number.");
            uint number = uint.Parse(Console.ReadLine());
            int mask = 1 << position;
            int result = (int)number & mask;
            int bit = result >> position;
            Console.WriteLine("Bit number 3 is: {0}", bit);

        }
    }
}
