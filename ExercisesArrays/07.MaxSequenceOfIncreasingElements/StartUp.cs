namespace _07.MaxSequenceOfIncreasingElements
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int currentLenght = 1;
            int longestLenght = 1;
            int currentStart = 0;
            int longestStart = 1;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > numbers[i - 1])
                {
                    currentLenght++;

                    if (currentLenght > longestLenght)
                    {
                        longestLenght = currentLenght;
                        longestStart = currentStart;
                    }
                }
                else
                {
                    currentLenght = 1;
                    currentStart = i;
                }
            }

            for (int i = longestStart; i < longestStart + longestLenght; i++)
            {
                Console.Write($"{numbers[i]} ");
            }
            Console.WriteLine();
        }
    }
}
