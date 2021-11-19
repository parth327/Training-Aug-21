//1.Create a list which will store 5 student names and then display it search it index number

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Pra1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> studentList = new List<string>();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Enter Student - {i} Name:");
                studentList.Add(Console.ReadLine());
            }
            Console.WriteLine("Enter search index(0-4)");
            int searchindex = Convert.ToInt32(Console.ReadLine());
            if (searchindex >= 0 && searchindex < 5)
            {
                Console.WriteLine($"Student found at index{searchindex} is {studentList[searchindex]}");
            }
            else {
                Console.WriteLine("Invalid Index");
            }
            Console.ReadKey();
        }
    }
}
