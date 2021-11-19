//Compute add of 2 numbers using lambda expression

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Ass2
{
    class Program
    {
        public delegate int Add(int a, int b);

        static void Main(string[] args)
        {
            Add addition = (a, b) => { return a + b; };
            int result = addition(5, 6);
            Console.WriteLine($"Addition result is : {result}");
            Console.ReadKey();
        }
    }
}
