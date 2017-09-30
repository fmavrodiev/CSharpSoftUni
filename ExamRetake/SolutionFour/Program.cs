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
            int numberOfDays = int.Parse(Console.ReadLine());

            double amountRakia = 0;
            double powerOfRakia = 0;
            int i = 1;
            while (numberOfDays >= i)
            {
                double amountRakiaInput = double.Parse(Console.ReadLine());
                double powerOfRakiaInput = double.Parse(Console.ReadLine());
                amountRakia += amountRakiaInput;
                powerOfRakia += amountRakiaInput * powerOfRakiaInput;
                i++;
            }
            Console.WriteLine($"Liter: {amountRakia:f2}");
            Console.WriteLine($"Degrees: {powerOfRakia / amountRakia:f2}");
            if ((powerOfRakia / amountRakia) < 38)
            {
                Console.WriteLine("Not good, you should baking!");
            }
            if ((powerOfRakia / amountRakia) >= 38 && (powerOfRakia / amountRakia) <= 42)
            {
                Console.WriteLine("Super!");
            }
            else
            {
                Console.WriteLine("Dilution with distilled water!");
            }
        }
    }
}
