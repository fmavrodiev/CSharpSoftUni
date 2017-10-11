namespace _06.MaxSequenceOfEqualElements
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            {
                int[] numbers = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int lenght = 1;
                int maxLenght = 1;
                int number = 0;

                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    if (numbers[i] == numbers[i + 1])
                    {
                        lenght++;
                    }
                    else
                    {
                        lenght = 1;
                    }

                    if (lenght > maxLenght)
                    {
                        maxLenght = lenght;
                        number = numbers[i];
                    }
                }

                for (int i = 0; i < maxLenght; i++)
                {
                    Console.Write($"{number} ");
                }
                Console.WriteLine();
            }
        }
    }
}
