using System;
using System.Linq;


namespace RandomFunctionsArray
{
    public class Program
    {
        public static void Main()
        {
            int[] myArray = new[] {0, 0, 0, 0, 0, 0, 0, 0, 0, 0};

            int myNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < myNumber; i++)
            {
                myArray[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Starts here...");

            foreach (int number in myArray)
            {
                Console.WriteLine(number);
            }
        }
    }
}
