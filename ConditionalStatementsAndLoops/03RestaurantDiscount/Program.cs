using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03RestaurantDiscount
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();

            string hallName = "";

            double priceOfHall = 0;
            double packagePrice = 0;
            double pricePerPerson = 0;
            double sumOfPackagePlusHall = 0;

            switch (package)
            {
                case "Normal":
                    packagePrice = 500;
                    if (groupSize <=50)
                    {
                        hallName = "Small Hall";
                        priceOfHall = 2500;
                    }
                    else if (groupSize <= 100 && groupSize > 50)
                    {
                        hallName = "Terrace";
                        priceOfHall = 5000;
                    }
                    else if (groupSize <= 120 && groupSize > 100)
                    {
                        hallName = "Great Hall";
                        priceOfHall = 7500;
                    }
                    else if (groupSize > 120)
                    {
                        Console.WriteLine("We do not have an appropriate hall.");
                        return;
                    }
                    sumOfPackagePlusHall = priceOfHall + packagePrice;
                    pricePerPerson = Math.Abs((sumOfPackagePlusHall * 0.05) - (priceOfHall + packagePrice));
                    pricePerPerson = pricePerPerson / groupSize;
                    Console.WriteLine($"We can offer you the {hallName}");
                    Console.WriteLine($"The price per person is {pricePerPerson:f2}$");

                    break;
                case "Gold":
                    packagePrice = 750;
                    if (groupSize <= 50)
                    {
                        hallName = "Small Hall";
                        priceOfHall = 2500;
                    }
                    else if (groupSize <= 100 && groupSize > 50)
                    {
                        hallName = "Terrace";
                        priceOfHall = 5000;
                    }
                    else if (groupSize <= 120 && groupSize > 100)
                    {
                        hallName = "Great Hall";
                        priceOfHall = 7500;
                    }
                    else if (groupSize > 120)
                    {
                        Console.WriteLine("We do not have an appropriate hall.");
                        return;
                    }
                    sumOfPackagePlusHall = priceOfHall + packagePrice;
                    pricePerPerson = Math.Abs((sumOfPackagePlusHall * 0.10) - (priceOfHall + packagePrice));
                    pricePerPerson = pricePerPerson / groupSize;
                    Console.WriteLine($"We can offer you the {hallName}");
                    Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
                    break;
                    case "Platinum":
                    packagePrice = 1000;
                    if (groupSize <= 50)
                    {
                        hallName = "Small Hall";
                        priceOfHall = 2500;
                    }
                    else if (groupSize <= 100 && groupSize > 50)
                    {
                        hallName = "Terrace";
                        priceOfHall = 5000;
                    }
                    else if (groupSize <= 120 && groupSize > 100)
                    {
                        hallName = "Great Hall";
                        priceOfHall = 7500;
                    }
                    else if (groupSize > 120)
                    {
                        Console.WriteLine("We do not have an appropriate hall.");
                        return;
                    }
                    sumOfPackagePlusHall = priceOfHall + packagePrice;
                    pricePerPerson = Math.Abs((sumOfPackagePlusHall * 0.15) - (priceOfHall + packagePrice));
                    pricePerPerson = pricePerPerson / groupSize;
                    Console.WriteLine($"We can offer you the {hallName}");
                    Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
                    break;
            }
        }
    }
}
