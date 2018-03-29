namespace _03.A_MinerTask
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            Dictionary<string, string> minerals = new Dictionary<string, string>();

            string input = Console.ReadLine();

            string[] miner = new string[] { };

            while (input != "stop")
            {
                miner = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                minerals.Add(miner[0], null);
                input = Console.ReadLine();
            }

            foreach (KeyValuePair<string, string> mine in minerals)
            {
                Console.WriteLine("{0} -> {1}", mine.Key, mine.Value);
            }
        }
    }
}
