//1.Create a user defined Exception Class AgeException. If Age is less than 0 it should be thrown an exception. And you need to handle that exception in student class.
//Note to create a user defined exception class you need to derive it from System.Exception class.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Day4Ass1
{
    class AgeException : Exception
    {
        public AgeException()
        {
            Console.WriteLine("Age cannot be less than zero!!");
        }
    }

    class student
    {
        int age;
        student()
        { 
        
        }
        public student(int age)
        {
            this.age = age;
            try
            {
                if (age < 0)
                {
                    throw new AgeException();
                }
                else
                {
                    Console.WriteLine("Age is Valid");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());
            student s = new student(age);
            Console.ReadKey();
        }
    }
}
