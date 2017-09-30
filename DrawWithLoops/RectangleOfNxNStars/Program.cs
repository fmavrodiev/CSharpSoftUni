using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleOfNxNStars
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            for (int row = 0; row < count; row++)
            {
                for (int col = 0; col < count; col++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
