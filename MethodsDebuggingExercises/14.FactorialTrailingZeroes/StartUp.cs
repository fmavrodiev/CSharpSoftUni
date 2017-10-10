namespace _14.FactorialTrailingZeroes
{
    using System;
    using System.Numerics;

    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            BigInteger fact = 1;

            for (int i = 1; i <= n; i++)
            {
                fact *= i;
            }

            PrintTrailingZeros(fact);
        }

        private static void PrintTrailingZeros(BigInteger fact)
        {
            int cntr = 0;

            while (fact > 0)
            {
                BigInteger currentDigit = fact % 10;

                if (currentDigit == 0)
                {
                    cntr++;
                }
                else
                {
                    break;
                }

                fact /= 10;
            }
            Console.WriteLine(cntr);
        }
    }
}
