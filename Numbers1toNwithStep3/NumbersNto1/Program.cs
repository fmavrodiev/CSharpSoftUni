using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersNto1
{
    class Program
    {
        static void Main(string[] args)
        {

            int maxNumber = int.Parse(Console.ReadLine());

            for (int currentNumber = 1; currentNumber <= maxNumber; currentNumber += maxNumber)
            {
                Console.WriteLine(maxNumber);
            }
        }
    }
}
