using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumNumberToDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberToSumDigitsFor = int.Parse(Console.ReadLine());

            int sum = 0;
            do
            {
                int currentLastDigit = numberToSumDigitsFor % 10;
                numberToSumDigitsFor /= 10;
                sum += currentLastDigit;
            } while (numberToSumDigitsFor > 0);

            Console.WriteLine(sum);
        }
    }
}
