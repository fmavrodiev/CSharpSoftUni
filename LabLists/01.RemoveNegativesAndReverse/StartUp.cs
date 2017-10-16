namespace _01.RemoveNegativesAndReverse
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            List<int> result = new List<int>();
            List<int> negative = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > 0)
                {
                    result.Add(numbers[i]);
                }
                if (numbers[i] < 0)
                {
                    negative.Add(numbers[i]);
                }
            }
            if (negative.Count > result.Count)
            {
                Console.WriteLine("empty");
                return;
            }
            result.Reverse();
            Console.WriteLine(String.Join(" ", result));
        }
    }
}
