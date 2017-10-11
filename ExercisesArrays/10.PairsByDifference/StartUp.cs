namespace _10.PairsByDifference
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
            int difference = int.Parse(Console.ReadLine());

            int cntr = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    int result = Math.Max(numbers[i], numbers[j]) - Math.Min(numbers[i], numbers[j]);

                    if (result == difference)
                    {
                        cntr++;
                    }
                }
            }

            Console.WriteLine(cntr);
        }
    }
}
