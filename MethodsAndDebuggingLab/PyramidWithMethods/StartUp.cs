namespace PyramidWithMethods
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                PrintNumber(1, i);
            }
            for (int i = n; i >= 1; i--)
            {
                PrintNumber(1, i);
            }
        }

        static void PrintNumber(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i);
                Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}
