﻿namespace DrawAFilledSquare
{
    using System;

    class StartUp
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            PrintHeader(n);
            for (int i = 0; i < n - 2; i++)
            {
                PrintBody(i);
                PrintHeader(n);
            }
        }

        private static void PrintBody(int n)
        {
            Console.Write('-');
            for (int i = 1; i < n; i++)
            {
                Console.Write("\\/");
            }
            Console.WriteLine('-');
        }

        private static void PrintHeader(int n)
        {
            Console.WriteLine(new string('-', 2 * n));
        }
    }
}
