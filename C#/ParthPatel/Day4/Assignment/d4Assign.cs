using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace D4Assign
{
    //1. Create a user defined Exception Class AgeException.If Age is less than 0 it should be thrown an exception.And you need to handle that exception in student class.
    //Note to create a user defined exception class you need to derive it from System.Exception class.

    //class Program
    //{
    //    class AgeException : Exception
    //    {
    //        public AgeException(string message)
    //        {
    //            Console.WriteLine(message);
    //        }
    //    }

    //    class Student
    //    {
    //        int age;

    //        public int Age
    //        {
    //            get { return age; }
    //            set
    //            {
    //                if (value < 0)
    //                {
    //                    throw (new AgeException("Invalid Age"));
    //                }
    //                age = value;
    //            }
    //        }
    //    }
    //    static void Main(string[] args)
    //    {
    //        try
    //        {
    //            Student student = new Student();
    //            Console.WriteLine("Enter Student Age :");
    //            student.Age = Convert.ToInt32(Console.ReadLine());

    //            Console.WriteLine($"Age {student.Age}");
    //            Console.ReadLine();
    //        }
    //        catch (AgeException msg)
    //        {
    //            Console.WriteLine(msg.Message.ToString());
    //            Console.ReadLine();
    //        }

    //    }
    //}

    //2. Create a user defined exception class NameException which will validate a Name and name should contain only character.
    //If name does not contain proper value it should throw an exception. You need to handle exception in student class.

    //class NameException : Exception
    //{
    //    public string msg()
    //    {
    //        return "Name is not Valid.";
    //    }
    //}

    //class Student
    //{
    //    string name;
    //    public string Name
    //    {
    //        get { return name; }
    //        set
    //        {
    //            if (!IsAllLetters(value))
    //            {
    //                throw (new NameException());
    //            }
    //            name = value;
    //        }
    //    }

    //    public static bool IsAllLetters(string s)
    //    {
    //        foreach (char c in s)
    //        {
    //            if (!Char.IsLetter(c))
    //                return false;
    //        }
    //        return true;
    //    }
    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        try
    //        {
    //            Student student = new Student();
    //            Console.WriteLine("Enter Student Name :");
    //            student.Name = Console.ReadLine();

    //            Console.WriteLine($"Student Name is {student.Name}");
    //            Console.ReadLine();
    //        }
    //        catch (NameException ne)
    //        {
    //            Console.WriteLine("Exception message : {0}", ne.msg());
    //            Console.ReadLine();
    //        }

    //    }
    //}


    //3. Create a user defined Exception DateException class which will validate date should not be less than the current date.
    //If date is less than current date it should throw an exception.

    class DateException : Exception
    {
        public string msg()
        {
            return "Date is less than current date.";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var todayDate = DateTime.Today;
                Console.WriteLine("Enter Date :");
                var userEnteredDate = Convert.ToDateTime(Console.ReadLine());
                if (userEnteredDate < todayDate)
                {
                    throw (new DateException());
                }
                Console.WriteLine($"Entered Date {userEnteredDate} is Valid.");
                Console.ReadLine();
            }
            catch (DateException de)
            {
                Console.WriteLine("Exception Message :{0}", de.msg());
                Console.ReadLine();
            }
        }
    }




}
