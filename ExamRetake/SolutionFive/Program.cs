using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionFive
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string str = "";

            for (int currentRow = 0; currentRow < 2 * number; currentRow++)
            {
                for (int currentCol = 0; currentCol < 3 * number; currentCol++)
                {
                    str = new string('.', number);
                    Console.WriteLine(str);
                }
            }
        }
    }
}
