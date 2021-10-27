//Day 1 Assignment
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsoleApp
{

   
    class Program
    {
        enum weekDay
        {
            monday, tuesday, wednesday, thursday, friday, saturday, sunday
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello");
            //Console.ReadLine();
            //1. Print sum of all the even numbers
            //int i, num,
            //  sum = 0;
            //Console.WriteLine("Enter a number :");
            //num = Convert.ToInt32(Console.ReadLine());
            //for (i = 2; i <= num; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        sum += i;
            //    }
            //}
            //Console.WriteLine("Total sum of all even numbers less than " + num + " is: " + sum);
            //Console.ReadLine();
            //2. Store your name in one string and find out how many vowel characters are there in your name.
            //var str="Parth";
            //int count=0;
            //for (var i = 0; i < str.Length ; i++)
            //{
            //    if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' ||
            //        str[i] == 'o' || str[i] == 'u' || str[i] == 'A' ||
            //        str[i] == 'E' || str[i] == 'I' || str[i] == 'O' ||
            //        str[i] == 'U')
            //    {
            //        count++;
            //    } 
            //}
            //Console.WriteLine("Name is: "  + str);
            //Console.WriteLine("Total Vowels in this Name : " + count);
            //Console.ReadLine();
            //3. Create a weekday enum and accept week day number and display week day.
            Console.WriteLine("Enter a week day number\n(range between 1 to 7)");
            int weekDayNum = Convert.ToInt32(Console.ReadLine());

            while (weekDayNum > 7)
            {
                Console.WriteLine("Please provide number between 1 to 7");
                weekDayNum = Convert.ToInt32(Console.ReadLine());
            }

            if (weekDayNum == (int)weekDay.sunday)
            {
                Console.WriteLine("Sunday");
            }
            else if (weekDayNum == (int)weekDay.monday)
            {
                Console.WriteLine("Monday");
            }
            else if (weekDayNum == (int)weekDay.tuesday)
            {
                Console.WriteLine("Tuesday");
            }
            else if (weekDayNum == (int)weekDay.wednesday)
            {
                Console.WriteLine("WednesDay");
            }
            else if (weekDayNum == (int)weekDay.thursday)
            {
                Console.WriteLine("Thursday");
            }
            else if (weekDayNum == (int)weekDay.friday)
            {
                Console.WriteLine("Friday");
            }
            else
            {
                Console.WriteLine("Saturday");
            }
            Console.ReadKey();
        }

        //4. Accept 10 student Name, Address, Hindi, English, Maths Marks,do the total and compute Grade.Note do it with Array and display the result in grid format
        //string[] arr = { "Name", "Address", "Hindi", "English", "Mathematics", "Grade" };

        //Console.WriteLine("Enter student details as mentioned");
        //string[,] name = new string[10, 2];

        //int[,] marks = new int[10, 3];

        //for (int i = 0; i < 10; i++)
        //{
        //    Console.WriteLine($"Enter student{i} Name : ");
        //    name[i, 0] = Console.ReadLine();

        //    Console.WriteLine($"Enter student{i} Address :");
        //    name[i, 1] = Console.ReadLine();

        //    Console.WriteLine($"Enter student{i} marks of Hindi English and Mathematics respectively :");

        //    marks[i, 0] = Convert.ToInt32(Console.ReadLine());
        //    marks[i, 1] = Convert.ToInt32(Console.ReadLine());
        //    marks[i, 2] = Convert.ToInt32(Console.ReadLine());

        //}
        //Console.WriteLine("------------------------------------------------------------\n");
        //Console.WriteLine($"| {arr[0]}\t\t| {arr[1]}\t\t| {arr[2]}\t\t| {arr[3]}\t\t| {arr[4]}\t\t| {arr[5]}|\n");
        //for (int i = 0; i < 10; i++)
        //{
        //    Console.WriteLine($"| {name[i, 0]}\t\t| {name[i, 1]}\t\t\t| {marks[i, 0]}\t\t| {marks[i, 1]}\t\t\t| {marks[i, 2]}\t\t\t| {(marks[i, 0] + marks[i, 1] + marks[i, 1]) / 3}|\n");
        //}
        //Console.WriteLine("------------------------------------------------------------\n");

        //Console.ReadKey();

        //5. Accept Age from user, if age is more than 18 eligible for vote otherwise it should be displayed as not eligible. Do it with ternary operator
        //int age;
        //Console.WriteLine("Enter Your Age");
        //age = Convert.ToInt32(Console.ReadLine());
        //var result = age > 18 ? "You are Eligible for Voting" : "You aren't Eligible for Voting";
        //Console.WriteLine(result);
        //Console.ReadLine();
        }
    }
}
