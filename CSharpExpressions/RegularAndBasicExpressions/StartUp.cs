namespace RegularAndBasicExpressions
{
    using System;
    using System.Numerics;

    public class StartUp
    {
        public static void Main()
        {
            // Declaring variables and data types:

            // bool Boolean values: true, false
            // byte    8 bit unsigned integer(0 to 255)
            // sbyte   8 bit signed integer(-128 to 127)
            // char character
            // decimal fixed point decimal number(fixed precision number)
            // double  double precision(64 - bit) floating point number(approx 14 significant digits)
            // float single precision(32 - bit) floating point number(approx 7 significant digits)
            // int 32 bit signed integer
            // uint    32 bit unsigned integer
            // long    64 bit signed integer
            // ulong   64 bit unsigned integer
            // short   16 bit signed integer(-32768 to 32767)
            // ushort  16 bit unsigned integer(0 to 65535)
            // string character string(text)

            byte centurie = byte.Parse(Console.ReadLine());

            short years = (short)(centurie * 100);
            int days = (int)(years * 365.2422);
            int hours = days * 24;
            long minutes = hours * 60;
            long seconds = minutes * 60;
            long milliseconds = seconds * 1000;
            BigInteger microseconds = milliseconds * 1000;
            BigInteger nanoseconds = microseconds * 1000;

            Console.WriteLine($"{centurie} centuries = {years} " +
                $"years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = " +
                $"{milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");

            // Math funcions
            // Math.Round(3.45) – round to integer number(mathematically)
            // Math.Round(2.3455, 3) – round with precision
            // Math.Ceiling() – round up to the nearest integer
            // Math.Floor() – round down to the nearest integer

            double a = 2.3455;
            Console.WriteLine(Math.Round(a));    // result: 2
            Console.WriteLine(Math.Round(a, 3)); // result: 2.346
            Console.WriteLine(Math.Ceiling(a));  // result: 3
            Console.WriteLine(Math.Floor(a));    // result: 2

            // Printing on the Console

            var name = "Gosho";
            var age = 5;
            Console.WriteLine("Name: " + name + ", Age: " + age);
            Console.WriteLine("Name: {0}, Age: {1}", name, age);
            Console.WriteLine($"Name: {name}, Age: {age}");

            // Formatting numbers in placeholders

            var grade = 5.5334;
            var percentage = 55;

            Console.WriteLine("{0:F2}", grade); // 5.53
            Console.WriteLine("{0:D3}", percentage); // 055

            // Language operators
            // Arithmetic: + - * / % ++ --
            // Logical: && || ^ !
            // Comparison: == != < > <= >=
            // Assignment: = += -= *= /= %= &= |= ^= <<= >>=

            // If-Else statements

            Console.WriteLine("Input hours as integer.");
            int hoursToEnter = int.Parse(Console.ReadLine());
            Console.WriteLine("Input minutes as integer.");
            int minutesToEnter = int.Parse(Console.ReadLine()) + 30;

            Console.Write("The time after 30 minutes is: ");

            if (minutesToEnter > 59)
            {
                hoursToEnter += 1;
                minutesToEnter -= 60;
            }
            if (hoursToEnter > 23)
            {
                hoursToEnter = 0;
            }
            if (minutesToEnter < 10)
            {
                Console.WriteLine("{0}:{1:D2}", hoursToEnter, minutesToEnter);              
            }
            else
            {
                Console.WriteLine("{0}:{1}", hoursToEnter, minutesToEnter);
            }

            // The switch-case statement

            var numberOfMonth = int.Parse(Console.ReadLine());

            switch (numberOfMonth)
            {
                case 1:
                    Console.WriteLine("January");
                    break;
                case 2:
                    Console.WriteLine("February");
                    break;
                case 3:
                    Console.WriteLine("March");
                    break;
                case 4:
                    Console.WriteLine("April");
                    break;
                default:
                    Console.WriteLine("Error!");
                    break;
            }

            // Loops - for-loops; while-loops; do-while-loops

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("i = " + i);
            }

            var numberForWhileLoop = 1;

            while (numberForWhileLoop <= 5)
            {
                Console.WriteLine(numberForWhileLoop);
                numberForWhileLoop++;
            }

            do
            {
                Console.WriteLine(numberForWhileLoop);
                numberForWhileLoop++;
            } while (numberForWhileLoop <= 5);

            // Handling errors with try-catch

            try
            {
                var someNumberToCatch = int.Parse(Console.ReadLine());
                Console.WriteLine("It is a number.");
            }
            catch (NotFiniteNumberException)
            {

                Console.WriteLine("Invalid input!");
            }


        }
    }
}
