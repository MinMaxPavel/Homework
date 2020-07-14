using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdDigitIsSeven
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a number.");
            int yourNumber = int.Parse(Console.ReadLine());

            if (yourNumber / 100 % 10 == 7)
                Console.WriteLine("True the third digit right to left is 7");
            else
                Console.WriteLine("False the third digit right to left is not seven");
        }
    }
}
