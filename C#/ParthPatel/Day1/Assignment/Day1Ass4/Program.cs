//4. Accept 10 student Name, Address, Hindi, English, Maths Marks ,do the total and compute Grade.
//Note do it with Array and display the result in grid format
     
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Ass4
{
    class Student
    {       
            string Name, Address, Grade;
            float Percentage;
            int Hindi, English, Maths, Total;

            public Student(string Name,string Address,int Hindi,int English,int Maths)
            {
                this.Name = Name;
                this.Address = Address;
                this.Hindi = Hindi;
                this.English = English;
                this.Maths = Maths;

                Total = Hindi + English + Maths;
                Percentage = Total / 3;
                if (Percentage > 90)
                {
                    Grade = "A+";
                }
                else if (Percentage > 80 & Percentage <= 90)
                {
                    Grade = "A";
                }
                else if (Percentage > 70 & Percentage <= 80)
                {
                    Grade = "B+";
                }
                else if (Percentage > 55 & Percentage <= 70)
                {
                    Grade = "B";
                }
                else if (Percentage > 40 & Percentage <= 55)
                {
                    Grade = "C";
                }
                else if (Percentage > 35 & Percentage <= 40)
                {
                    Grade = "D";
                }
                else
                {
                    Grade = "F";
                }
            }
            public void display() 
            {
                Console.WriteLine(".......................");
                Console.WriteLine($"{ Name}|{ Address}|{ Hindi}|{ English}|{ Maths}|{ Total}|{ Percentage}|{ Grade}");
            }

    }
    class Assign4
    {
        static void Main(string[] args)
        {
            String Name, Address;
            int Hindi, English, Maths;
            Student[] studata = new Student[1];
            for (int i = 0; i < studata.Length; i++)
            {
                Console.WriteLine("Enter Name of student");
                Name = Console.ReadLine();
                Console.WriteLine("Enter Address");
                Address = Console.ReadLine();
                Console.WriteLine("Enter marks of hindi subject out of 100 :");
                Hindi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter marks of english subject out of 100 :");
                English = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter marks of maths subject out of 100 :");
                Maths = Convert.ToInt32(Console.ReadLine());

                studata[i] = new Student(Name, Address, Hindi, English, Maths);
         
            }
            Console.WriteLine("Name|Address|Hindi|English|Maths|Total|Percentage|Grade");
            for (int i = 0; i < studata.Length; i++)
            {
                studata[i].display();
            }
            Console.ReadKey();

        }
    }
}

