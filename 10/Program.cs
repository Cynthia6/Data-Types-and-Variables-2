using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {

            int cen = int.Parse(Console.ReadLine());

            int year = cen * 100;
            int days = (int)(365.2422m * year);
            decimal hours =  days * 24m;
            decimal minutes =  hours * 60m;
            decimal seconds = minutes * 60m;
            decimal mili =  seconds * 1000m;
            decimal micro =  mili * 1000m;
            decimal nano =  micro * 1000m;
            Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes = {5} seconds = {6} milliseconds = {7} microseconds = {8} nanoseconds", 
                cen,  year, days, hours, minutes, seconds, mili, micro,nano );


        }
    }
}
