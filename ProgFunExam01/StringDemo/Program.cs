using System;

namespace StringDemo
{
    class Program
    {
        static void Main()
        {
            var text = Console.ReadLine();
            var pattern = Console.ReadLine();

            var count = 0;
            var index = -1;

            while (true)
            {
                index = text.IndexOf(pattern, index + 1);
                if (index == -1)
                    break;
                count++;
            }

            Console.WriteLine(count);
        }
    }
}
