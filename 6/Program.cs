using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {

            string greetings = "Hello";
            string word = "World";
            object con = greetings + " " + word;
            string result = (string)con;
            Console.WriteLine(result);
        }
    }
}
