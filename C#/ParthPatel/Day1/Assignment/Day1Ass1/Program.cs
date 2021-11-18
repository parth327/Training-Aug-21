using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Ass1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, num, sum = 0;
            Console.WriteLine("Enter the maximum limit value :");
            num = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= num; i++)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine("Sum of all even numbers upto\n" + num +" is " + sum);
            Console.ReadLine();

        }
    }
}
