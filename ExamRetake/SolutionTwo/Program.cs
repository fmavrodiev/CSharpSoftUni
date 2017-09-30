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
            double timeFirstBro = double.Parse(Console.ReadLine());
            double timeSecondBro = double.Parse(Console.ReadLine());
            double timeThirdBro = double.Parse(Console.ReadLine());
            double fishingTime = double.Parse(Console.ReadLine());

            double totalTime = 1 / ((1 / timeFirstBro) + (1 / timeSecondBro) + (1 / timeThirdBro));
            double timeWithBreak = (totalTime * 0.15) + totalTime;
            double time = fishingTime - timeWithBreak;

            Console.WriteLine($"Cleaning time: {timeWithBreak:f2}");

            if (time > 0)
            {
                Console.WriteLine($"Yes, there is a surprise - time left -> {Math.Floor(time):f0} hours.");
            }
            else
            {
                Console.WriteLine($"No, there isn't a surprise - shortage of time -> {Math.Exp(time):f0} hours.");
            }
        }
    }
}
