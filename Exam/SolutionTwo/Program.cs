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
            double earningsLeva = double.Parse(Console.ReadLine());
            double averageScore = double.Parse(Console.ReadLine());
            double minimumWage = double.Parse(Console.ReadLine());

            double mediumScholarShip = (minimumWage * 35) /100;
            double fullScholarShip = averageScore * 25;

            if (earningsLeva < minimumWage)
            {
                if (averageScore > 4.50 && mediumScholarShip > fullScholarShip)
                {
                    Console.WriteLine($"You get a Social scholarship {mediumScholarShip} BGN");
                }
                else if (averageScore > 4.50 && mediumScholarShip < fullScholarShip)
                {
                    Console.WriteLine($"You get a scholarship for excellent results {fullScholarShip} BGN");
                }
            }
            else
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
        }
    }
}
