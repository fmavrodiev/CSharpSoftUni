namespace _01.HelloName
{
    using System;

    public class StartUp
    {
        static string nameOfPerson = Console.ReadLine();

        public static void Main()
        {
            PrintName();
        }

        private static void PrintName()
        {
            Console.WriteLine($"Hello, {nameOfPerson}!");
        }
    }
}
