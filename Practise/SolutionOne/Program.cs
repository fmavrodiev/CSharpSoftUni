using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionOne
{
    class Program
    {
        static void Main(string[] args)
        {
            int cakeWidth = int.Parse(Console.ReadLine());
            int cakeLenght = int.Parse(Console.ReadLine());
            int allPieces = cakeLenght * cakeWidth;
            string str = Console.ReadLine();
            int grabbedPieces = 0;
            while ((str != "STOP") && (allPieces >= 0))
            {
                grabbedPieces = int.Parse(str);
                allPieces -= grabbedPieces;
                if (allPieces >= 0)
                {
                    str = Console.ReadLine();
                }
            }
            if (str == "STOP" && allPieces > 0)
            {
                Console.WriteLine($"{allPieces} pieces are left.");
            }
            else
            {
                if (allPieces <= 0)
                {
                    Console.WriteLine($"No more cake left! You need {Math.Abs(allPieces)} pieces more.");
                }
            }
        }
    }
}
