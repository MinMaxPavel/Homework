using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumOfFiveNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 5 valid numbers: ");

            double numbOne = double.Parse(Console.ReadLine());
            double numbTwo = double.Parse(Console.ReadLine());
            double numbThree = double.Parse(Console.ReadLine());
            double numbFour = double.Parse(Console.ReadLine());
            double numbFive = double.Parse(Console.ReadLine());

            double sum = numbOne + numbTwo + numbThree + numbFour + numbFive;
            Console.WriteLine("The sum of the 5 numbers is: {0}", sum);
        }
    }
}
