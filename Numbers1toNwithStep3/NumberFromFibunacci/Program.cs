using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberFromFibunacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberFibunacci = int.Parse(Console.ReadLine());

            int a = 1;
            int b = 1;
            for (int currentRotation = 0; currentRotation < numberFibunacci; currentRotation++)
            {
                int newB = a + b;
                a = b;
                b = newB;
            }
            Console.WriteLine(a);
        }
    }
}
