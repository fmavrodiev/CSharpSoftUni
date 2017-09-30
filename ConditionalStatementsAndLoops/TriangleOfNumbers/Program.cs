namespace TriangleOfNumbers
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            for (int rowLenght = 1; rowLenght <= number; rowLenght++)
            {
                for (int collumLenght = 1; collumLenght <= rowLenght; collumLenght++)
                {
                    Console.Write($"{rowLenght} ");
                }
                Console.WriteLine();
            }
        }
    }
}
