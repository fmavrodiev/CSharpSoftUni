using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sequence2kPlus1
{
    class Program
    {
        static void Main(string[] args)
        {
            int NumberToCheck = int.Parse(Console.ReadLine());

            bool isPrime = true;

            if (NumberToCheck <= 1)
            {
                isPrime = false;
            }
            else
            {
                for (int currentDivider = 2; currentDivider < NumberToCheck; currentDivider++)
                {
                    if (NumberToCheck % currentDivider == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }
            if (isPrime)
            {
                Console.WriteLine("Prime.");
            }
            else
            {
                Console.WriteLine("Not Prime.");
            }
        }
    }
}
