using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionOne
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int winght = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double precentege = double.Parse(Console.ReadLine());

            precentege = precentege * 0.01;

            double volume = lenght * winght * height;
            volume = volume * 0.001;
            volume = volume * (1 - precentege);

            Console.WriteLine($"{volume:f3}");
        }
    }
}
