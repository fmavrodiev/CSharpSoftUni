using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foodOrfood
{
    class Program
    {
        static void Main(string[] args)
        {
            string food = Console.ReadLine().ToLower();
            bool isFruit = food == "banana" || food == "apple" || food == "cherry" || food == "lemon" || food == "grapes" || food == "kiwi";
            bool isVegetable = food == "tomato" || food == "cucumber" || food == "pepper" || food == "carrot";

            if (isFruit)
            {
                Console.WriteLine("fruit");
            }
            else if (isVegetable)
            {
                Console.WriteLine("vegetable");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
