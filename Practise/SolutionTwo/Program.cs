using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int pieces = width * length;
            string input;
            while ((input = Console.ReadLine()) != "STOP")
            {
                int piecesToTake = int.Parse(input);
                if (piecesToTake > pieces)
                {
                    Console.WriteLine($"No more cake left! You need {piecesToTake - pieces} pieces more.");
                    return;
                }
                pieces -= piecesToTake;
            }
            Console.WriteLine($"{pieces} pieces are left.");
        }
    }
}
