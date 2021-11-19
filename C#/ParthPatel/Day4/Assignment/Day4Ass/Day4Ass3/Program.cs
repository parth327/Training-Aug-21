﻿//3.Create a user defined Exception DateException class which will validate date should not be less than the current date. 
//    If date is less than current date it should throw an exception.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Ass3
{
    public class DateException : Exception 
    {
        public DateException()
        {
            Console.WriteLine("Cannot Enter Date Less Than Current Date!!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Date(DD/MM/YY):");
            DateTime inpdate = DateTime.Parse(Console.ReadLine());
            try
            {
                if (inpdate < DateTime.Now.Date)
                {
                    throw new DateException();
                }
                else
                {
                    Console.WriteLine("Date is Valid");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            Console.ReadKey();
        }
    }
}
