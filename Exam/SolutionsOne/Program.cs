using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsOne
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfSquareTables = int.Parse(Console.ReadLine());
            double lenghtOfTables = double.Parse(Console.ReadLine());
            double wightOfTables = double.Parse(Console.ReadLine());

            double sum = numberOfSquareTables * ((lenghtOfTables + 2 * 0.30) * (wightOfTables + 2 * 0.30));

            double sumKareta = numberOfSquareTables * ((lenghtOfTables / 2) * (lenghtOfTables / 2));

            double sumOfsquare = sum * 7;

            double sumOfKareta = sumKareta * 9;

            double totalSum = sumOfsquare + sumOfKareta;

            Console.WriteLine($"{totalSum:f2} USD");
            Console.WriteLine($"{totalSum * 1.85:f2} BGN");
        }
    }
}
