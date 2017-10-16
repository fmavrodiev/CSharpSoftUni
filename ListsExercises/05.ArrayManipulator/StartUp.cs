namespace _05.ArrayManipulator
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            string command = Console.ReadLine();

            while (command != "print")
            {
                var commandArgs = command
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();
                if (commandArgs[0] == "add")
                {
                    numbers.Insert(int.Parse(commandArgs[1]), int.Parse(commandArgs[2]));

                }
                else if (commandArgs[0] == "addMany")
                {

                }
                command = Console.ReadLine();
            }

            Console.WriteLine($"[{String.Join(", ", numbers)}]");
        }
    }
}
