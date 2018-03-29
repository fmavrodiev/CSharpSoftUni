namespace DragonArmy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            //Dictionary<string, Dictionary<string, List<double>>> dragons = new Dictionary<string, Dictionary<string, List<double>>>();

            double numberOfDragons = double.Parse(Console.ReadLine());

            //for (double i = 0; i < numberOfDragons; i++)
            //{
            //    string[] commandArgs = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            //    if (dragons.ContainsKey(commandArgs[0]))
            //    {
            //        dragons.Add(commandArgs[0], new Dictionary<string, List<double>>());
            //        dragons[commandArgs[0]].Add(commandArgs[1], new List<double>());
            //        dragons[commandArgs[0]][commandArgs[1]].Add(double.Parse(commandArgs[2]));
            //    }
            //}

            List<Dragon> dragon = new List<Dragon>();

            for (double i = 0; i < numberOfDragons; i++)
            {
                string[] commandArgs =
                    Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                Dragon newDragon = CreateDragon(commandArgs);

                if (!dragon.Any(x => x.Name == newDragon.Name && x.Type == newDragon.Type))
                {
                    dragon.Add(CreateDragon(commandArgs));
                }
                else
                {
                    var reminder = dragon.FirstOrDefault(a => a.Name == newDragon.Name && a.Type == newDragon.Type);
                    if (commandArgs[2] != "null")
                    {
                        reminder.Damage = double.Parse(commandArgs[2]);
                    }
                    else
                    {
                        reminder.Damage = 45;
                    }
                    if (commandArgs[3] != "null")
                    {
                        reminder.Health = double.Parse(commandArgs[3]);
                    }
                    else
                    {
                        reminder.Health = 250;
                    }
                    if (commandArgs[4] != "null")
                    {
                        reminder.Armor = double.Parse(commandArgs[4]);
                    }
                    else
                    {
                        reminder.Armor = 10;
                    }
                }
            }

            foreach (string typeOfDragon in dragon.Select(d => d.Type).Distinct().ToList())
            {
                var averageDamage = dragon.Where(d => d.Type == typeOfDragon).Average(d => d.Damage);
                var averageHealth = dragon.Where(d => d.Type == typeOfDragon).Average(d => d.Health);
                var averageArmor = dragon.Where(d => d.Type == typeOfDragon).Average(d => d.Armor);

                Console.WriteLine($"{typeOfDragon}::({averageDamage:f2}/{averageHealth:f2}/{averageArmor:f2})");

                foreach (var oneDragon in dragon.Where(d => d.Type == typeOfDragon).OrderBy(e => e.Name))
                {
                    Console.WriteLine($"-{oneDragon.Name} -> damage: {oneDragon.Damage}, health: {oneDragon.Health}, armor: {oneDragon.Armor}");
                }
            }
        }

        public static Dragon CreateDragon(string[] commandArgs)
        {
            Dragon dragonss = new Dragon();

            dragonss.Type = commandArgs[0];
            dragonss.Name = commandArgs[1];
            if (commandArgs[2] != "null")
            {
                dragonss.Damage = double.Parse(commandArgs[2]);
            }
            else
            {
                dragonss.Damage = 45;
            }
            if (commandArgs[3] != "null")
            {
                dragonss.Health = double.Parse(commandArgs[3]);
            }
            else
            {
                dragonss.Health = 250;
            }
            if (commandArgs[4] != "null")
            {
                dragonss.Armor = double.Parse(commandArgs[4]);
            }
            else
            {
                dragonss.Armor = 10;
            }

            return dragonss;
        }
    }

    public class Dragon
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public double Damage { get; set; }
        public double Health { get; set; }
        public double Armor { get; set; }
    }
}
