using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numbersFromOneToN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a valid number");

            int n = int.Parse(Console.ReadLine());
            
            for (int i = i = 1; i<=n; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
