using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Ass
{
    class Assignemnt
    {
        class Assignment
        {
            static void Main(string[] args)
            {
                Person.Person[] arr = new Person.Person[5];
                string firstname, lastname, email;
                DateTime dateofbirth;

                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine($"Enter Person{i + 1}'s Details...");
                    Console.WriteLine("Enter Person's First Name:");
                    firstname = Console.ReadLine();
                    Console.WriteLine("Enter Person's Last Name:");
                    lastname = Console.ReadLine();
                    Console.WriteLine("Enter Person's Email:");
                    email = Console.ReadLine();
                    Console.WriteLine("Enter Person's Date of Birth(DD/MM/YYYY):");
                    dateofbirth = DateTime.Parse(Console.ReadLine());
                    arr[i] = new Person.Person(firstname, lastname, email, dateofbirth);
                }
                Console.WriteLine("Screen Name | Is Adult? | Is Birthday Today? | Sun Sign | Chinese Sign");
                Console.WriteLine("-----------------------------------------------------------------------");
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine($"{arr[i].ScreenName} | {arr[i].Adult} | {arr[i].Birthday} | {arr[i].SunSign} | {arr[i].ChineseSign}");
                }
                Console.ReadKey();
            }
        }
    }
}
