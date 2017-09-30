using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string leap = Console.ReadLine();
            long p = long.Parse(Console.ReadLine());
            long h = long.Parse(Console.ReadLine());
            decimal days = 0;
            days += h;
            decimal normalWeekendPlays = ((48 - h) / 4.00m) * 3;
            days += normalWeekendPlays;
            decimal holidayPlays = (p / 3.00m) * 2;
            days += holidayPlays;
            if (leap == "leap")
            {
                days += (days / 100.00m) * 15;
            }
            Console.WriteLine((int)days);
        }
    }
}
