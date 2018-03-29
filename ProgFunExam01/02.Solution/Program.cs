using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Solution
{
    class Program
    {
        static void Main()
        {
            List<string> input = new List<string>();
            input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            string sum = "";
            string exit = "";
            while (exit != "3:1")
            {
                var commandArgs = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (commandArgs[0] == "merge")
                {
                    if (input.ElementAtOrDefault(int.Parse(commandArgs[1])) != null && input.ElementAtOrDefault(int.Parse(commandArgs[2])) != null)
                    {
                        sum += input[int.Parse(commandArgs[1])] + input[int.Parse(commandArgs[2])];
                    }
                }
                if (commandArgs[0] == "divide")
                {
                    sum += input[int.Parse(commandArgs[1])].Split(new[]{' '}, int.Parse(commandArgs[2])).ToString();
                }

                exit = commandArgs[0];
            }
            Console.WriteLine(sum);
        }
    }
}
