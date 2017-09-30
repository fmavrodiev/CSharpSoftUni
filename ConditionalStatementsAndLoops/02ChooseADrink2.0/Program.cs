using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02ChooseADrink2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            double priceWater = 0.70;
            double priceCoffee = 1.00;
            double priceBeer = 1.70;
            double priceTea = 1.20;

            switch (profession)
            {
                case "Athlete":
                    Console.WriteLine($"The {profession} has to pay {(priceWater * quantity):f2}.");
                    break;
                case "Chef":
                    Console.WriteLine($"The {profession} has to pay {(priceTea * quantity):f2}.");
                    break;
                case "SoftUni Student":
                    Console.WriteLine($"The {profession} has to pay {(priceBeer * quantity):f2}.");
                    break;
                case "Businessman":
                case "Businesswoman":
                    Console.WriteLine($"The {profession} has to pay {(priceCoffee * quantity):f2}.");
                    break;
                default:
                    Console.WriteLine($"The {profession} has to pay {(priceTea * quantity):f2}.");
                    break;
            }
        }
    }
}
