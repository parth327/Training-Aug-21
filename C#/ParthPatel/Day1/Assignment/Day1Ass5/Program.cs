using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Ass5
{
    class Program
    {
        static void Main(string[] args)
        {
            //5. Accept Age from user, if age is more than 18 eligible for vote otherwise it should be displayed as not eligible.Do it with ternary operator
            int age;
            string status;
            Console.WriteLine("Enter Your Age");
            age = Convert.ToInt32(Console.ReadLine());
            status = (age > 18) ? "You are eligible for vote" : "You are not eligible for vote";
            Console.WriteLine(status);
            Console.ReadLine();
        }
    }
}
