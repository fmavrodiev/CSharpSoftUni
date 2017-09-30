using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeComissions
{
    class Program
    {
        static void Main(string[] args)
        {
            var town = Console.ReadLine();
            var s = double.Parse(Console.ReadLine());

            if (s > 0 && s <= 500)
            {
                if (town == "Sofia")
                    Console.WriteLine("{0:f2}", s * 5 / 100);
                else if (town == "Varna")
                    Console.WriteLine("{0:f2}", s * 4.5 / 100);
                else if (town == "Plovdiv")
                    Console.WriteLine("{0:f2}", s * 5.5 / 100);
                else if (!(town == "Sofia" || town == "Varna" || town == "Plovdiv"))
                    Console.WriteLine("error");

            }
            else if (s > 500 && s <= 1000)
            {
                if (town == "Sofia")
                    Console.WriteLine("{0:f2}", s * 7 / 100);
                else if (town == "Varna")
                    Console.WriteLine("{0:f2}", s * 7.5 / 100);
                else if (town == "Plovdiv")
                    Console.WriteLine("{0:f2}", s * 8 / 100);
                else if (!(town == "Sofia" || town == "Varna" || town == "Plovdiv"))
                    Console.WriteLine("error");

            }
            else if (s > 1000 && s <= 10000)
            {
                if (town == "Sofia")
                    Console.WriteLine("{0:f2}", s * 8 / 100);
                else if (town == "Varna")
                    Console.WriteLine("{0:f2}", s * 10 / 100);
                else if (town == "Plovdiv")
                    Console.WriteLine("{0:f2}", s * 12 / 100);
                else if (!(town == "Sofia" || town == "Varna" || town == "Plovdiv"))
                    Console.WriteLine("error");

            }
            else if (s > 10000)
            {
                if (town == "Sofia")
                    Console.WriteLine("{0:f2}", s * 12 / 100);
                else if (town == "Varna")
                    Console.WriteLine("{0:f2}", s * 13 / 100);
                else if (town == "Plovdiv")
                    Console.WriteLine("{0:f2}", s * 14.5 / 100);
                else if (!(town == "Sofia" || town == "Varna" || town == "Plovdiv"))
                    Console.WriteLine("error");

            }

            else if (s < 0)
            {
                Console.WriteLine("error");
            }
        }
    }
}
