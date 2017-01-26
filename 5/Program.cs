using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

          if ( Convert.ToBoolean(word) == true )
              Console.WriteLine("Yes");
          else if (Convert.ToBoolean(word) == false)
              Console.WriteLine("No");


        }
    }
}
