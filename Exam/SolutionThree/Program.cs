using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionThree
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPhotos = int.Parse(Console.ReadLine());
            string size = Console.ReadLine().ToUpper();
            string type = Console.ReadLine().ToLower();

            double basePrice = 0;
            double baseSum = 0;
            if (size == "9X13")
            {
                basePrice = 0.16;
                if (numberOfPhotos < 50)
                {
                    baseSum = numberOfPhotos * basePrice;
                }
                if (numberOfPhotos >= 50)
                {
                    baseSum = numberOfPhotos * basePrice;
                    baseSum = ((baseSum * 5) / 100) - baseSum;
                }
                if (type == "online")
                {
                    baseSum = ((baseSum * 2) / 100) - baseSum;
                    
                }
            }
            if (size == "10X15")
            {
                basePrice = 0.16;
                if (numberOfPhotos < 80)
                {
                    baseSum = numberOfPhotos * basePrice;
                }
                if (numberOfPhotos >= 80)
                {
                    baseSum = numberOfPhotos * basePrice;
                    baseSum = ((baseSum * 3) / 100) - baseSum;
                }
                if (type == "online")
                {
                    baseSum = ((baseSum * 2) / 100) - baseSum;

                }
            }
            if (size == "13X18")
            {
                basePrice = 0.38;
                if (numberOfPhotos < 50)
                {
                    baseSum = numberOfPhotos * basePrice;
                }
                if (numberOfPhotos >= 50 && numberOfPhotos <= 100)
                {
                    baseSum = numberOfPhotos * basePrice;
                    baseSum = ((baseSum * 3) / 100) - baseSum;
                }
                if (numberOfPhotos > 100)
                {
                    baseSum = numberOfPhotos * basePrice;
                    baseSum = ((baseSum * 5) / 100) - baseSum;
                }
                if (type == "online")
                {
                    baseSum = ((baseSum * 2) / 100) - baseSum;

                }
            }
            if (size == "20X30")
            {
                basePrice = 2.90;
                if (numberOfPhotos < 10)
                {
                    baseSum = numberOfPhotos * basePrice;
                }
                if (numberOfPhotos >= 10 && numberOfPhotos <= 50)
                {
                    baseSum = numberOfPhotos * basePrice;
                    baseSum = ((baseSum * 7) / 100) - baseSum;
                }
                if (numberOfPhotos > 50)
                {
                    baseSum = numberOfPhotos * basePrice;
                    baseSum = ((baseSum * 9) / 100) - baseSum;
                }
                if (type == "online")
                {
                    baseSum = ((baseSum * 2) / 100) - baseSum;

                }
            }
            Console.WriteLine($"{Math.Abs(baseSum):f2}BGN");
        }
    }
}
