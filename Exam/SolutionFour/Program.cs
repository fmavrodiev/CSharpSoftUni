using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionFour
{
    class Program
    {
        static void Main(string[] args)
        {
            int cakeWight = int.Parse(Console.ReadLine());
            int cakeLenght = int.Parse(Console.ReadLine());

            int cakeSize = cakeWight * cakeLenght;

            while (true)
            {
                int pieceTaken = int.Parse(Console.ReadLine());
                cakeSize = cakeSize - pieceTaken;
                if (cakeSize <= 0)
                {
                    Console.WriteLine($"No more cake left! You need {Math.Abs(cakeSize)}pieces more!");
                    return;
                }
                if (pieceTaken.GetType() == typeof(string))
                {
                    Console.WriteLine($"{cakeSize} pieces are left.");
                    return;
                }
            }
        }
    }
}
