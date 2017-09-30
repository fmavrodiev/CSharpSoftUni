using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareFrame
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            char plus = '+';
            char dash = '-';
            char pipe = '|';
            char whiteSpace = ' ';

            int universal = size - 2;

            Console.Write(plus);

            for (int currentCol = 0; currentCol < universal; currentCol++)
            {
                Console.Write("{0}{1}",whiteSpace, dash);
            }
            Console.WriteLine("{0}{1}", whiteSpace, plus);

            for (int currentRow = 0; currentRow < universal; currentRow++)
            {
                Console.Write(pipe);

                for (int currentCol = 0; currentCol < universal; currentCol++)
                {
                    Console.Write("{0}{1}", whiteSpace, dash);
                }
                Console.WriteLine("{0}{1}", whiteSpace, pipe);
            }

            Console.Write(plus);

            for (int currentCol = 0; currentCol < universal; currentCol++)
            {
                Console.Write("{0}{1}", whiteSpace, dash);
            }
            Console.WriteLine("{0}{1}", whiteSpace, plus);
        }
    }
}
