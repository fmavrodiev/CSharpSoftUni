using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebitCardNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstGroup = int.Parse(Console.ReadLine());
            int secondGroup = int.Parse(Console.ReadLine());
            int thirdGroup = int.Parse(Console.ReadLine());
            int fourthGroup = int.Parse(Console.ReadLine());
            Console.WriteLine(firstGroup.ToString("D4") + " " + secondGroup.ToString("D4") + " " + thirdGroup.ToString("D4") + " " + fourthGroup.ToString("D4"));
        }
    }
}
