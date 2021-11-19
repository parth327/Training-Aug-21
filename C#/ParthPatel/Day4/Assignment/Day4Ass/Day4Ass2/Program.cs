//2.Create a user defined exception class NameException which will validate a Name and name should contain only character.
//If name does not contain proper value it should throw an exception. You need to handle exception in student class.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Ass2
{
    class NameException : Exception 
    {
        public NameException()
        {
            Console.WriteLine("Name cannot contain a digit");
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Name :");
            string Name = Console.ReadLine();
            StringBuilder nameestr = new StringBuilder(Name);
            char[] x = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            try
            {
                for (int i = 0; i < nameestr.Length; i++)
                {
                    if (x.Contains(nameestr[i]))
                    {
                        throw new NameException();
                    }
                }
                Console.WriteLine("Name is valid");
            }
            catch (Exception e)
            {
                Console.WriteLine(e); 
            }

            Console.ReadKey();
        }
    }
}
