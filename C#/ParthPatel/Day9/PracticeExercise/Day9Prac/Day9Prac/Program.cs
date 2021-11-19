using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9Prac
{
    class Program
    {
        static void Main(string[] args)
        {
            Method1();
            Method2();
            Method3();
            Console.ReadKey();
        }
        static void Method1()
        {
            Console.WriteLine("Method1...");
        }
        static async Task Method2()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 15; i++)
                {
                    Console.WriteLine("Method2....");
                }
            });
        }
        static void Method3()
        {
            Console.WriteLine("Method3...");
        }
    }
}
