using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PyramidOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxNumber = int.Parse(Console.ReadLine());

            int numbersOnRow = 1;
            int currentNumber = 1;

            while (true)
            {
                for (int currentRotation = 0; currentRotation < numbersOnRow; currentRotation++)
                {
                    Console.Write($"{currentNumber++} ");

                    if (currentNumber == maxNumber + 1)
                    {
                        return;
                    }
                }
                numbersOnRow++;
                Console.WriteLine();
            }
        }
    }
}
