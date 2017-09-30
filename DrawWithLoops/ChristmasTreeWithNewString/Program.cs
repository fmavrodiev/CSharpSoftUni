using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasTreeWithNewString
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int rows = size + 1;
            for (int currentRow = 0; currentRow < rows; currentRow++)
            {
                string emptySpaces = new string(' ', size - currentRow);
                string asterisk = new string('*', currentRow);
                Console.WriteLine("{0}{1}{2}{1}", emptySpaces, asterisk, " | " );
            }
        }
    }
}
