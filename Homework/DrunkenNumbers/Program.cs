using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrunkenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = 0;
            int v = 0;
            for (int i = 0; i < n; i++)
            {
                int beers = int.Parse(Console.ReadLine());
                beers = Math.Abs(beers);
                int digits = 0;
                int tempNumber = beers;

                while (tempNumber > 0)
                {
                    tempNumber /= 10;
                    digits++;
                }

                for (int j = 0; j < digits / 2; j++)
                {
                    v += beers % 10;
                    beers /= 10;
                }
                if (digits % 2 != 0)
                {
                    int midDigit = beers % 10;
                    beers /= 10;
                    m += midDigit;
                    v += midDigit;
                }
                for (int j = 0; j < digits / 2; j++)
                {
                    m += beers % 10;
                    beers /= 10;
                }
            }

            if (m > v)
            {
                Console.WriteLine("M {0}", m - v);
            }
            else if (m < v)
            {
                Console.WriteLine("V {0}", v - m);
            }
            else
            {
                Console.WriteLine("No {0}", m + v);
            }
        }
    }
}
