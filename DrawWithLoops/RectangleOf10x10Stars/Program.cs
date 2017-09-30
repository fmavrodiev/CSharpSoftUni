using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleOf10x10Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 10;

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
