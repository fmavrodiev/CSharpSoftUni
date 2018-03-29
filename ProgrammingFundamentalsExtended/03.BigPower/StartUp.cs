using System;
using System.Numerics;

namespace _03.BigPower
{
    public class StartUp
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            BigInteger bigNumber = 0;

            bigNumber = BigInteger.Pow(number, number);

            Console.WriteLine(bigNumber);
        }
    }
}
