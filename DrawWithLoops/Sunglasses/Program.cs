using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunglasses
{
    class Program
    {
        static void Main(string[] args)
        {
            int glassesSize = int.Parse(Console.ReadLine());
            var a = ((2 * glassesSize - Math.Pow((-1), glassesSize) + 1) / 4);
            if (glassesSize >= 3 && glassesSize <= 100)
            {
                for (int currentRow = 1; currentRow < glassesSize + 1; currentRow++)
                {
                    string space = string.Concat(Enumerable.Repeat(" ", glassesSize).ToArray());
                    string asterix = string.Concat(Enumerable.Repeat("*", glassesSize * 2).ToArray());
                    string italic = string.Concat(Enumerable.Repeat("/", 2 * glassesSize - 2).ToArray());
                    string straight = string.Concat(Enumerable.Repeat("|", glassesSize).ToArray());


                    if (currentRow == 1 || currentRow == glassesSize)
                    {
                        Console.WriteLine("{0}{1}{0}", asterix, space);
                    }
                    else
                    {
                        if (currentRow == a) { space = straight; }
                        Console.WriteLine("{0}{1}{0}{2}{0}{1}{0}", "*", italic, space);
                    }
                }
            }
            else
            {

            }
        }
    }
}
