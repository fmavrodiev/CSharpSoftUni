using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamOne
{
    class Program
    {
        static void Main(string[] args)
        {
            int workingDaysPerMonth = int.Parse(Console.ReadLine());
            double moneyPerDay = double.Parse(Console.ReadLine());
            double usdVsbgn = double.Parse(Console.ReadLine());

            double mountlyIncome = (workingDaysPerMonth * moneyPerDay);
            double annualIncome = (mountlyIncome * 12) + (mountlyIncome * 2.5);
            double afterTax = Math.Abs(((annualIncome * 25) / 100) - annualIncome);

            double averageSalaryPerDay = afterTax / 365;
            double sum = averageSalaryPerDay * usdVsbgn;

            Console.WriteLine($"{sum:f2}");
        }
    }
}
