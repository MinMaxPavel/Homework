using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticEquasion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c: ");
            double c = double.Parse(Console.ReadLine());

            double Discriminant = (b * b) - 4 * a * c;
            if (Discriminant > 0)
            {
                double xOne = (-b + Math.Sqrt(Discriminant)) / (2 * a);
                double xTwo = (-b - Math.Sqrt(Discriminant)) / (2 * a);
                Console.WriteLine("The discriminant is positive so we get TWO real solutions :\nx1 = {0} and x2= {1}", xOne, xTwo);
            }
            else if (Discriminant == 0)
            {
                double xOne = (-b + Math.Sqrt(Discriminant)) / (2 * a);
                Console.WriteLine("The discriminant in the formula is 0 so we get only one real solution. x = {0}", xOne);
            }
            else
            {
                Console.WriteLine("Invalid roots.");
            }
        }
    }
}
