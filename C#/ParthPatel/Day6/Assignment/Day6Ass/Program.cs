//Compute area of rectangle using func delegate

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Ass
{   class Program
    {

        static double Area(double length, double width)
        {
            return length * width;
        }
        static void Main(string[] args)
        {
            Func<double, double, double> Rectangle = Area;
            double result = Rectangle(5.5, 4.5);
            Console.WriteLine($"Area of Rectangle is : {result}");
            Console.ReadKey();
        }
    }
}
