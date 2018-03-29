using System;

namespace RealNumberTypes
{
    public class StartUp
    {
        public static void Main()
        {
            byte floatingPoint = byte.Parse(Console.ReadLine());
            decimal number = decimal.Parse(Console.ReadLine());

            Console.WriteLine(Math.Round(number, floatingPoint));
        }
    }
}
