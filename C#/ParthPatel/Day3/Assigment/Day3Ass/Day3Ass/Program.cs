//Implement all the oops concept for Employee payroll system.

//Create above class hierarchy, implement inheritance and polymorphism.



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Ass
{
    interface IEmp
    {
        void Get();
        void Display();
        void Salary();
    }
    abstract class Employee : IEmp
    {
        static int Id = 0;
        string Name, Address, PanNumber;
        public virtual void Get()
        {
            Id += 1;
            Console.WriteLine("Enter Employee Name:");
            Name = Console.ReadLine();
            Console.WriteLine("Enter Employee Address:");
            Address = Console.ReadLine();
            Console.WriteLine("Enter Employee PanNumber:");
            PanNumber = Console.ReadLine();
        }
        public virtual void Display()
        {
            Console.WriteLine($"Employee Id is {Id}");
            Console.WriteLine($"Employee Name is {Name}");
            Console.WriteLine($"Employee Address is {Address}");
            Console.WriteLine($"Employee Pan Card Number is {PanNumber}");
        }
        public abstract void Salary();
    }
    class Parttime : Employee 
    {
        int NoofHr, SaleperHr;
        public override void Salary()
        {
            Console.WriteLine("Enter no of hours worked:");
            NoofHr = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter sales per hr:");
            SaleperHr = Convert.ToInt32(Console.ReadLine());
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Employee Salary is {NoofHr * 25 + SaleperHr * 25}");
        }
    }
    class Fulltime : Employee
    {
        int Basic, Hra, Ta, Da;

        public override void Salary()
        {
            Console.WriteLine("Enter Basic Salary:");
            Basic = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Hra:");
            Hra = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Ta:");
            Ta = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Da:");
            Da = Convert.ToInt32(Console.ReadLine());
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Employee Salary is {Basic + Hra + Ta + Da}");
        }

    }
    class Assignment
    {
        public void functioncall(IEmp obj)
        {
            obj.Get();
            obj.Salary();
            obj.Display();
        }
        static void Main(string[] args)
        {
            IEmp obj = null;
            Console.WriteLine("Choose Your job-Profile:\n1.Parttime\n2.Fulltime");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    obj = new Parttime();
                    break;
                case 2:
                    obj = new Fulltime();
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }

            Assignment a = new Assignment();
            a.functioncall(obj);
            Console.ReadKey();
        }

    }

}
