using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalfSumElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int max = 0;
            for (int i = 0; i < n; i++)
            {
                int m = int.Parse(Console.ReadLine());
                sum += m;
                if (i == 0)
                    max = m;
                if (m > max)
                    max = m;
            }
            sum -= max;
            if (sum == max)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("sum = {0}", max);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("diff = {0}", Math.Abs(sum - max));
            }
        }
    }
}
