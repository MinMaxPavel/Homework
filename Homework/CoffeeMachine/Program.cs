using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine()); 
            int n2 = int.Parse(Console.ReadLine()); 
            int n3 = int.Parse(Console.ReadLine()); 
            int n4 = int.Parse(Console.ReadLine()); 
            int n5 = int.Parse(Console.ReadLine()); 
            double a = double.Parse(Console.ReadLine());
            double p = double.Parse(Console.ReadLine());
            double moneyInside = (n1 * 0.05) + (n2 * 0.10) + (n3 * 0.20) + (n4 * 0.50) + (n5 * 1.00);
            double changeToGive = a - p;
            if (a >= p && changeToGive <= moneyInside) 
            {
                Console.WriteLine("Yes {0:0.00}", moneyInside - changeToGive);
            }
            else if (a < p)
            {
                Console.WriteLine("More {0:0.00}", p - a);
            }
            else if (a > p && changeToGive > moneyInside)
            {
                Console.WriteLine("No {0:0.00}", changeToGive - moneyInside);
            }
        }
    }
}
