using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumOfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input 3 numbers:");

            double numbOne = double.Parse(Console.ReadLine());
            double numbTwo = double.Parse(Console.ReadLine());
            double numbThree = double.Parse(Console.ReadLine());

            double sum = numbOne + numbTwo + numbThree;
            Console.WriteLine("The sum of {0} + {1} + {2} is: {3}",numbOne,numbTwo,numbThree,sum);
        }
    }
}
