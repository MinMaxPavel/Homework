﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckAPlayCard
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a card sign to check:");
            string card = Console.ReadLine();

            switch (card)
            {

                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                case "10":
                case "J":
                case "Q":
                case "K":
                case "A":
                    Console.WriteLine("Yes");
                    break;
                default:
                    Console.WriteLine("No");
                    break;
            }
        }
    }
}
