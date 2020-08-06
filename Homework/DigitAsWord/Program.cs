using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitAsWord
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a digit from 0 to 9 :");
            string digit = Console.ReadLine();
            string word;
            switch (digit)
            {
                case "0":
                    word = "Zero";
                    break;
                case "1":
                    word = "One";
                    break;
                case "2":
                    word = "Two";
                    break;
                case "3":
                    word = "Three";
                    break;
                case "4":
                    word = "Four";
                    break;
                case "5":
                    word = "Five";
                    break;
                case "6":
                    word = "Six";
                    break;
                case "7":
                    word = "Seven";
                    break;
                case "8":
                    word = "Eight";
                    break;
                case "9":
                    word = "Nine";
                    break;
                default:
                    word = "Invalid input";
                    break;
            }
            Console.WriteLine(word);
        }
    }
}
