using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Christmas_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            string whiteSpace = " ";
            string asterisk = "*";
            string pipe = "|";

            int rows = size + 1;

            for (int currentRow = 0; currentRow < rows; currentRow++)
            {
                string whiteSpaces = string.Empty;
                string asterisks = string.Empty;

                for (int currentWhiteSpace = 0; currentWhiteSpace < size - currentRow; currentWhiteSpace++)
                {
                    whiteSpaces += whiteSpace;
                }

                for (int currentAsterisk = 0; currentAsterisk < currentRow; currentAsterisk++)
                {
                    asterisks += asterisk;
                }

                Console.WriteLine("{0}{1}{2}{1}", whiteSpaces, asterisks, pipe);
            }
        }
    }
}
