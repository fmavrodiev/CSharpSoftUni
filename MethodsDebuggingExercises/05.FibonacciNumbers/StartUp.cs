namespace _05.FibonacciNumbers
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            int start = 0;
            int end = 1;
            int sum = 1;

            int wantedNumber = GetFibonacciNumber(start, end, sum, number);

            Console.WriteLine(wantedNumber);
        }
        public static int GetFibonacciNumber(int start, int end, int sum, int number)
        {
            for (int i = 0; i < number; i++)
            {
                sum = start + end;

                start = end;
                end = sum;

            }

            return sum;
        }

    }
}
