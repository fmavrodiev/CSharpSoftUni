namespace _02.AppendLists
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            List<string> numbers = Console.ReadLine()
                .Split('|')
                .ToList();

            numbers.RemoveAll(string.IsNullOrWhiteSpace);

            Console.WriteLine(String.Join("", numbers));
        }
    }
}
