using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13
{
    class Program
    {
        static void Main(string[] args)
        {

            char symbol = char.Parse(Console.ReadLine());

            if (char.IsDigit(symbol)) Console.WriteLine("digit");
            else if ("aeiou".Contains(symbol)) Console.WriteLine("vowel");
            else Console.WriteLine("other");

            //char symbol;

            //Console.Write("Input a symbol: ");
            //symbol = Convert.ToChar(Console.ReadLine());

            //if ((symbol == 'a') || (symbol == 'e') || (symbol == 'i') ||
            //        (symbol == 'o') || (symbol == 'u'))
            //    Console.WriteLine("It's a lowercase vowel.");
            //else if ((symbol >= '0') && (symbol <= '9'))
            //    Console.WriteLine("It's a digit.");
            //else
            //    Console.Write("It's another symbol.");
        }
    }
}
