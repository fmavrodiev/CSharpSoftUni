
namespace CharacterStats
{
    using System;
    class Program
    {
        public static void Main()
        {
            string name = Console.ReadLine();
            int currrentHealth = int.Parse(Console.ReadLine());
            int maxHealth = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Health: |{new string ('|', currrentHealth) + new string('.', maxHealth - currrentHealth)}|");
            Console.WriteLine($"Energy: |{new string('|', currentEnergy) + new string('.', maxEnergy - currentEnergy)}|");
        }
    }
}
