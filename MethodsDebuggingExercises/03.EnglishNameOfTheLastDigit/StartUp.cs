namespace _03.EnglishNameOfTheLastDigit
{
    using System;
    using System.Linq;

    public class StartUp
    {

        public static void Main()
        {
            string numberToRead = Console.ReadLine();
            string lastDigit = numberToRead.Last().ToString();
            string lastDigitName = GetLastDigit(lastDigit);
            Console.WriteLine(lastDigitName);
        }

        private static string GetLastDigit(string lastDigit)
        {
            string digitName = "";

            if (lastDigit == "1")
            {
                digitName = "one";
            }
            else if (lastDigit == "2")
            {
                digitName = "two";
            }
            else if (lastDigit == "3")
            {
                digitName = "three";
            }
            else if (lastDigit == "4")
            {
                digitName = "four";
            }
            else if (lastDigit == "5")
            {
                digitName = "five";
            }
            else if (lastDigit == "6")
            {
                digitName = "six";
            }
            else if (lastDigit == "7")
            {
                digitName = "seven";
            }
            else if (lastDigit == "8")
            {
                digitName = "eight";
            }
            else if (lastDigit == "9")
            {
                digitName = "nine";
            }
            else if (lastDigit == "0")
            {
                digitName = "zero";
            }
            return digitName;
        }
    }
}
