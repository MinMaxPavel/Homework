using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckBitAtGivenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input number:");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Input position:");
            int position = int.Parse(Console.ReadLine());
            int mask = 1 << position;
            int result = number & mask;
            int bit = result >> position;
            bool bitAtPosition = bit == 1;
            Console.WriteLine("The bit at position {0} in the number {1} has value of 1: {2}", position, number, bitAtPosition);
        }
    }
}
