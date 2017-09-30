using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            var art = Console.ReadLine().ToLower();
            var day = Console.ReadLine().ToLower();
            var col = double.Parse(Console.ReadLine());
            var price = 1d;

            if (day == "monday" || day == "tuesday" || day == "wednesday" || day == "thursday" || day == "friday")
            {
                if (art == "banana")
                {
                    price = 2.50;
                    price = col * price;
                }
                else if (art == "apple")
                {
                    price = col * 1.20;
                }
                else if (art == "orange")
                {
                    price = col * 0.85;
                }
                else if (art == "grapefruit")
                {
                    price = col * 1.45;
                }
                else if (art == "kiwi")
                {
                    price = col * 2.70;
                }
                else if (art == "pineapple")
                {

                    price = col * 5.50;
                }
                else if (art == "grapes")
                {
                    price = col * 3.85;
                }
            }
            else
            {
                Console.WriteLine("error");
            }

            if (day == "saturday" || day == "sunday")
            {
                if (art == "banana")
                {
                    price = col * 2.70;
                }
                else if (art == "apple")
                {
                    price = col * 1.25;
                }
                else if (art == "orange")
                {
                    price = col * 0.90;
                }
                else if (art == "grapefruit")
                {
                    price = col * 1.60;
                }
                else if (art == "kiwi")
                {
                    price = col * 3.00;
                }
                else if (art == "pineapple")
                {
                    price = col * 5.60;
                }
                else if (art == "grapes")
                {
                    price = col * 4.20;
                }

            }

            if (price != 1)
            {
                Console.WriteLine("{0:F2}", price);
            }

            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
