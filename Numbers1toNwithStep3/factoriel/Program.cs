using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factoriel
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberToCalculateFacturielFor = int.Parse(Console.ReadLine());

            int factoriel = 1;

            do
            {
                factoriel *= numberToCalculateFacturielFor--;

            } while (numberToCalculateFacturielFor > 0);

            Console.WriteLine(factoriel);
        }
    }
}
