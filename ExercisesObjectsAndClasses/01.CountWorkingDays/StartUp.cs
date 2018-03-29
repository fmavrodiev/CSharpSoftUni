using System.Globalization;

namespace _01.CountWorkingDays
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            DateTime startDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InstalledUICulture);
            DateTime endDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InstalledUICulture);

            int countOfWorkingDays = 1;

            for (DateTime currentDate = startDate; currentDate <= endDate; currentDate = currentDate.AddDays(1))
            {
                if (currentDate.DayOfWeek != DayOfWeek.Saturday && currentDate.DayOfWeek != DayOfWeek.Sunday)
                {
                    Console.WriteLine(countOfWorkingDays);
                    countOfWorkingDays++;
                }
            }
        }
    }
}
