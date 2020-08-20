using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheHorror
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int counter = 0;
            int sum = 0;
            int position = 0;
            foreach (char C in input)
            {
                if (position % 2 == 0)
                {
                    switch (C)
                    {
                        case '0': counter++; break;
                        case '1': counter++; sum += 1; break;
                        case '2': counter++; sum += 2; break;
                        case '3': counter++; sum += 3; break;
                        case '4': counter++; sum += 4; break;
                        case '5': counter++; sum += 5; break;
                        case '6': counter++; sum += 6; break;
                        case '7': counter++; sum += 7; break;
                        case '8': counter++; sum += 8; break;
                        case '9': counter++; sum += 9; break;
                        default:
                            break;
                    }
                }
                position++;
            }
            Console.WriteLine(counter + " " + sum);
        }
    }
}
