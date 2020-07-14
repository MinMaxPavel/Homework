using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOrEvenIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input an integer value:");
            int userIntegerInput = int.Parse(Console.ReadLine());

            if (userIntegerInput % 2 == 0)
                Console.WriteLine("The integer {0} is even", userIntegerInput);

            else
                Console.WriteLine("The integer {0} is odd", userIntegerInput);
        }
    }
}
