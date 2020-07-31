using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trapezoids
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please inout the a, b and h for your trapezoid.");
            Console.Write("a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("h: ");
            double h = double.Parse(Console.ReadLine());
            double area = (a + b) / 2 * h;
            Console.WriteLine("The area of your trapezoid is {0}", area);
        }
    }
}
