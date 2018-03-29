using System;

namespace IntegerTypes
{
    public class StartUp
    {
        public static void Main()
        {
            byte byteNumber = byte.Parse(Console.ReadLine());
            uint intNumber = uint.Parse(Console.ReadLine());
            int uintNumber = int.Parse(Console.ReadLine());
            long ulongNumber = long.Parse(Console.ReadLine());

            Console.WriteLine($"{byteNumber} {intNumber} {uintNumber} {ulongNumber}");
        }
    }
}
