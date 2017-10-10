namespace _07.PrimesInGivenRange
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            List<long> primeNums = new List<long>();

            long start = long.Parse(Console.ReadLine());
            long end = long.Parse(Console.ReadLine());

            for (long i = start; i <= end; i++)
            {
                if (IsPrime(i))
                {
                    primeNums.Add(i);
                }
            }

            Console.WriteLine(string.Join(", ", primeNums));
        }

        private static bool IsPrime(long i)
        {
            if (i == 0 || i == 1)
            {
                return false;
            }

            for (int j = 2; j <= Math.Sqrt(i); j++)
            {
                if (i % j == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}