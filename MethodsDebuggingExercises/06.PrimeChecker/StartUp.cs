namespace _06.PrimeChecker
{
    using System;

    public class StartUp
    {

        public static void Main()
        {
            long number = long.Parse(Console.ReadLine());

            bool isPrime = NumberToCheck(number);

            Console.WriteLine(isPrime);
        }

        private static bool NumberToCheck(long number)
        {
            if (number == 0 || number == 1)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
