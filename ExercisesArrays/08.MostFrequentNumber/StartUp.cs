namespace _08.MostFrequentNumber
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

            int cntr = 0;
            int longestOccurence = 0;
            int mostFrequentNum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                cntr = 0;
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (numbers[j] == numbers[i])
                    {
                        cntr++;
                    }
                }

                if (cntr > longestOccurence)
                {
                    longestOccurence = cntr;
                    mostFrequentNum = numbers[i];
                }
            }

            Console.WriteLine(mostFrequentNum);
        }
    }
}
