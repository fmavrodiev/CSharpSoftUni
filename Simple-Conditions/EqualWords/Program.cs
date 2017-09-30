using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string word1 = Console.ReadLine();

            word = word.ToLower();
            word1 = word1.ToLower();

            if (word.Equals(word1))
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}