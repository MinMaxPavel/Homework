using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormatingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter value for a , it must be from 0 to 500.");
            Console.Write("a: ");
            int a = int.Parse(Console.ReadLine());
            while (a < 0 || a > 500)
            {
                Console.WriteLine("Enter value for a , it must be from 0 to 500.");
                Console.Write("a: ");
                a = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter value for b");
            Console.Write("b: ");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter value for c");
            Console.Write("c: ");
            double c = double.Parse(Console.ReadLine());

            Console.Write("|" + Convert.ToString(a, 16).PadRight(10, ' ').ToUpper() + "|" + Convert.ToString(a, 2).PadLeft(10, '0'));
            Console.Write("|{0, 10:F2}|{1, -10:F3}|", b, c);
        }
    }
}
