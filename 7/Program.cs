﻿using System;
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

            temp = a; //5
            a = b;//10
            b = a;//10

            Console.WriteLine("Before:");
            Console.WriteLine("a = 5");
            Console.WriteLine("b = 10");
            Console.WriteLine("After:");
            Console.WriteLine("a = " + b);
            Console.WriteLine("b = " + temp);
        }
    }
}
