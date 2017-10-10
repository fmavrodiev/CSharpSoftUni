namespace _2.MaxMethod
{
    using System;

    public class StartUp
    {
        static int firstNumber = int.Parse(Console.ReadLine());
        static int secondNumber = int.Parse(Console.ReadLine());
        static int thirdNumber = int.Parse(Console.ReadLine());

        public static void Main()
        {
            GetMax();
        }

        private static void GetMax()
        {
            int maxNumber = Math.Max(firstNumber, Math.Max(secondNumber, thirdNumber));
            Console.WriteLine(maxNumber);
        }
    }
}
