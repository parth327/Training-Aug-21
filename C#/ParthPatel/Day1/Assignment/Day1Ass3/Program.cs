//3. Create a weekday enum and accept week day number and display week day.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Ass3
{
    class Program
    {
        enum weekDay
        {
            Monday=1,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number for weekday between 1 to 7(Monday is 1)");
            int x = Convert.ToInt32(Console.ReadLine());
            switch (x)
            {
                case (int)weekDay.Monday:
                    Console.WriteLine("Monday");
                    break;
                case (int)weekDay.Tuesday:
                    Console.WriteLine("Tuesday");
                    break;
                case (int)weekDay.Wednesday:
                    Console.WriteLine("Wednesday");
                    break;
                case (int)weekDay.Thursday:
                    Console.WriteLine("Thursday");
                    break;
                case (int)weekDay.Friday:
                    Console.WriteLine("Friday");
                    break;
                case (int)weekDay.Saturday:
                    Console.WriteLine("Saturday");
                    break;
                case (int)weekDay.Sunday:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Enter No. between 1 to 7");
                    break;
            }
            Console.ReadLine();
        }
    }
}
