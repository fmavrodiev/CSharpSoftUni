using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string productName = Console.ReadLine();
            string town = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            string sofiaTown = "Sofia";
            string plovdivTown = "Plovdiv";
            string varnaTwon = "Varna";

            string coffee = "coffee";
            string water = "water";
            string beer = "beer";
            string sweets = "sweets";
            string peanuts = "peanuts";

            double priceOfProduct = 0.0;

            if (town == sofiaTown)
            {
                if (productName == coffee)
                {
                    priceOfProduct = 0.5;

                }
                else if (productName == water)
                {
                    priceOfProduct = 0.8;
                }
                else if (productName == beer)
                {
                    priceOfProduct = 1.2;
                }
                else if (productName == sweets)
                {
                    priceOfProduct = 1.45;
                }
                else if (productName == peanuts)
                {
                    priceOfProduct = 1.6;
                }
            }
            else if (town == plovdivTown)
            {
                if (productName == coffee)
                {
                    priceOfProduct = 0.4;

                }
                else if (productName == water)
                {
                    priceOfProduct = 0.7;
                }
                else if (productName == beer)
                {
                    priceOfProduct = 1.15;
                }
                else if (productName == sweets)
                {
                    priceOfProduct = 1.3;
                }
                else if (productName == peanuts)
                {
                    priceOfProduct = 1.5;
                }

            }
            else if (town == varnaTwon)
            {
                if (productName == coffee)
                {
                    priceOfProduct = 0.45;

                }
                else if (productName == water)
                {
                    priceOfProduct = 0.7;
                }
                else if (productName == beer)
                {
                    priceOfProduct = 1.1;
                }
                else if (productName == sweets)
                {
                    priceOfProduct = 1.35;
                }
                else if (productName == peanuts)
                {
                    priceOfProduct = 1.55;
                }

            }
            double totalPrice = priceOfProduct * quantity;
            Console.WriteLine(totalPrice);
        }
    }
}
