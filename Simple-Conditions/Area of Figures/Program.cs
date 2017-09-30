using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            double area;
            string userinput = Console.ReadLine();
            if (userinput == "square")
            {
                double SideA = double.Parse(Console.ReadLine());
                area = Math.Pow(SideA, 2);
                Console.WriteLine("{0:0.###}", area);
            }
            if (userinput == "rectangle")
            {
                double SideA = double.Parse(Console.ReadLine());
                double SideB = double.Parse(Console.ReadLine());
                area = SideA * SideB;
                Console.WriteLine("{0:0.###}", area);
            }
            if (userinput == "circle")
            {
                double Radius = double.Parse(Console.ReadLine());
                area = Math.PI * Math.Pow(Radius, 2);
                Console.WriteLine("{0:0.###}", area);
            }
            if (userinput == "triangle")
            {
                double SideA = double.Parse(Console.ReadLine());
                double Height = double.Parse(Console.ReadLine());
                area = (SideA * Height) / 2.0;
                Console.WriteLine("{0:0.###}", area);
            }
        }
    }
}
