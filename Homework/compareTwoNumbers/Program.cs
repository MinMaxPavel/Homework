using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compareTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two valid numbers to compare");
            Console.WriteLine("1st number: ");
            decimal numberOne = decimal.Parse(Console.ReadLine());
            Console.WriteLine("2nd number: ");
            decimal numberTwo = decimal.Parse(Console.ReadLine());
            Console.WriteLine("The greatest number is: {0}",Math.Max(numberOne, numberTwo));
        }
    }
}
