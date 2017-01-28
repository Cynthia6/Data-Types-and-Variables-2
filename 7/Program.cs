using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;

            int temp = 0;

            temp = a;
            a = b;
            b = a;

            Console.WriteLine("Before:");
            Console.WriteLine("a = 5");
            Console.WriteLine("b = 10");
            Console.WriteLine("After:");
            Console.WriteLine("a = " + b);
            Console.WriteLine("b = " + temp);
        }
    }
}
