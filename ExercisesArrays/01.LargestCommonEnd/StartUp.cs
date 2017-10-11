namespace _01.LargestCommonEnd
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            string[] firstArray = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string[] secondArray = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int leftCount = FindMaxCommonItems(firstArray, secondArray);
            Array.Reverse(firstArray);
            secondArray = secondArray.Reverse().ToArray();
            int rightCount = FindMaxCommonItems(firstArray, secondArray);   

            Console.WriteLine($"{Math.Max(leftCount, rightCount)}");
        }

        private static int FindMaxCommonItems(string[] firstArray, string[] secondArray)
        {
            int lenghtOfArray = Math.Min(firstArray.Length, secondArray.Length);
            int count = 0;

            for (int i = 0; i < lenghtOfArray; i++)
            {
                if (firstArray[i] == secondArray[i])
                {
                    count++;
                }
                else
                {
                    break;
                }
            }

            return count;
        }
    }
}
