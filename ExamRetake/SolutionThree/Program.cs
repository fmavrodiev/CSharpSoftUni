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
            string duration = Console.ReadLine().ToLower();
            string contractType = Console.ReadLine().ToLower();
            string addedBroadband = Console.ReadLine().ToLower();
            int durationOfPayment = int.Parse(Console.ReadLine());

            double oneYearSmall = 9.98;
            double oneYearMiddle = 18.99;
            double oneYearLarge = 25.98;
            double oneYearExtraLarge = 35.99;
            double twoYearSmall = 8.58;
            double twoYearMiddle = 17.09;
            double twoYearLarge = 23.59;
            double twoYearExtraLarge = 31.79;

            double finalPrice = 0;

            if (duration == "one" && contractType == "small")
            {
                if (addedBroadband == "yes")
                {
                    oneYearSmall += 5.50;
                }
                finalPrice = oneYearSmall * durationOfPayment;
                Console.WriteLine($"{Math.Abs(finalPrice):f2} lv.");
            }
            if (duration == "one" && contractType == "middle")
            {
                if (addedBroadband == "yes")
                {
                    if (addedBroadband == "yes")
                    {
                        oneYearMiddle += 4.35;
                    }
                    finalPrice = oneYearMiddle * durationOfPayment;
                    Console.WriteLine($"{Math.Abs(finalPrice):f2} lv.");
                }
            }
            if (duration == "one" && contractType == "large")
            {
                if (addedBroadband == "yes")
                {
                    oneYearLarge += 4.35;
                }
                finalPrice = oneYearLarge * durationOfPayment;
                Console.WriteLine($"{Math.Abs(finalPrice):f2} lv.");
            }
            if (duration == "one" && contractType == "extralarge")
            {
                if (addedBroadband == "yes")
                {
                    oneYearExtraLarge += 3.85;
                }
                finalPrice = oneYearExtraLarge * durationOfPayment;
                Console.WriteLine($"{Math.Abs(finalPrice):f2} lv.");
            }
            if (duration == "two" && contractType == "small")
            {
                if (addedBroadband == "yes")
                {
                    twoYearSmall += 5.5;
                }
                finalPrice = twoYearSmall * durationOfPayment;
                finalPrice = ((finalPrice * 3.75) / 100) - finalPrice;
                Console.WriteLine($"{Math.Abs(finalPrice):f2} lv.");
            }
            if (duration == "two" && contractType == "middle")
            {
                if (addedBroadband == "yes")
                {
                    twoYearMiddle += 4.35;
                }
                finalPrice = twoYearMiddle * durationOfPayment;
                finalPrice = ((finalPrice * 3.75) / 100) - finalPrice;
                Console.WriteLine($"{Math.Abs(finalPrice):f2} lv.");
            }
            if (duration == "two" && contractType == "large")
            {
                if (addedBroadband == "yes")
                {
                    twoYearLarge += 4.35;
                }
                finalPrice = twoYearLarge * durationOfPayment;
                finalPrice = ((finalPrice * 3.75) / 100) - finalPrice;
                Console.WriteLine($"{Math.Abs(finalPrice):f2} lv.");
            }
            if (duration == "two" && contractType == "extralarge")
            {
                if (addedBroadband == "yes")
                {
                    twoYearExtraLarge += 3.85;
                }
                finalPrice = twoYearExtraLarge * durationOfPayment;
                finalPrice = ((finalPrice * 3.75) / 100) - finalPrice;
                Console.WriteLine($"{Math.Abs(finalPrice):f2} lv.");
            }

        }
    }
}
