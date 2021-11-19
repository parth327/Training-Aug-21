//2.Create a stack which will store Age of person and display it last in first out order.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Pra2
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> personAge = new Stack<int>();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Enter Person Age:");
                personAge.Push(Convert.ToInt32(Console.ReadLine()));
            }
            foreach (int i in personAge)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
