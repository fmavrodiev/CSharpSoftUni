using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilesToKilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            double mile = double.Parse(Console.ReadLine());
            double kilometer = mile * 1.60934;
            Console.WriteLine(kilometer.ToString("F2"));
        }
    }
}
