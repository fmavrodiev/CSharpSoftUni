namespace CountTheInteger
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int numbers = 0;

            for (numbers = 0; numbers <= 100; numbers++)
            {
                try
                {
                    int count = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {

                    break;
                }
            }
            Console.WriteLine(numbers);
        }
    }
}

