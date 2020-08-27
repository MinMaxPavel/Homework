using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fire
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int n = int.Parse(Console.ReadLine());

            for (int rowA = 1; rowA <= n / 2; rowA++)
            {
                for (int i = 0; i < n / 2 - rowA; i++) 
                {
                    Console.Write(".");
                }
                Console.Write("#"); 
                for (int i = 1; i < rowA; i++) 
                {
                    Console.Write("..");
                }
                Console.Write("#"); 
                for (int i = 0; i < n / 2 - rowA; i++) 
                {
                    Console.Write(".");
                }
                Console.Write("\n");
            }


            for (int rowB = 1; rowB <= n / 4; rowB++)
            {
                for (int i = 1; i < rowB; i++)
                {
                    Console.Write(".");
                }
                Console.Write("#");
                for (int i = 0; i < n - rowB * 2; i++)
                {
                    Console.Write(".");
                }
                Console.Write("#");
                for (int i = 1; i < rowB; i++)
                {
                    Console.Write(".");
                }
                Console.Write("\n");
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write("-");
            }
            Console.Write("\n");


            for (int RowC = 0; RowC < n / 2; RowC++)
            {
                for (int i = 0; i < RowC; i++)
                {
                    Console.Write(".");
                }
                for (int i = 0; i < n / 2 - RowC; i++)
                {
                    Console.Write("\\");
                }
                for (int i = 0; i < n / 2 - RowC; i++)
                {
                    Console.Write("/");
                }
                for (int i = 0; i < RowC; i++)
                {
                    Console.Write(".");
                }
                Console.WriteLine();
            }
        }
    }
}
