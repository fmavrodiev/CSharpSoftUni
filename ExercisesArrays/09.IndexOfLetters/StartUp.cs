﻿namespace _09.IndexOfLetters
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            char[] letters = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            string word = Console.ReadLine();

            foreach (char letter in word)
            {
                Console.WriteLine($"{letter} -> {Array.IndexOf(letters, letter)}");
            }
        }
    }
}
