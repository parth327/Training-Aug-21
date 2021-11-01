using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d3Prac
{
    //Inheritance
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Car myCar = new Car();
    //        myCar.honk();
    //        Console.WriteLine(myCar.brand + " " + myCar.modelName);
    //    }
    //}
    //class Car : Vehicle 
    //{
    //    public string modelName = "Mustang";  
    //}
    //class Vehicle 
    //{
    //    public string brand = "Ford";  
    //    public void honk()             
    //    {
    //        Console.WriteLine("Tuut, tuut!");
    //        Console.ReadLine();
    //    }
    //}
    //Polymorphism
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Animal myAnimal = new Animal();
    //        Animal myPig = new Pig();  
    //        Animal myDog = new Dog();  
    //        myAnimal.animalSound();
    //        myPig.animalSound();
    //        myDog.animalSound();
    //    }
    //}
    //class Animal   
    //{
    //    public void animalSound()
    //    {
    //        Console.WriteLine("The animal makes a sound");
    //    }
    //}

    //class Pig : Animal 
    //{
    //    public void animalSound()
    //    {
    //        Console.WriteLine("The pig says: wee wee");
    //    }
    //}

    //class Dog : Animal 
    //{
    //    public void animalSound()
    //    {
    //        Console.WriteLine("The dog says: bow wow");
    //    }
    //}
    //Encapsulation
    class Program
    {
        static void Main(string[] args)
        {
            User u = new User();
            u.Name = "Parth Patel";
            u.Location = "Ahmedabad";
            Console.WriteLine("Name: " + u.Name);
            Console.WriteLine("Location: " + u.Location);
            Console.WriteLine("\nPress Enter Key to Exit..");
            Console.ReadLine();
        }
    }
    class User
    {
        private string location;
        private string name;
        public string Location
        {
            get
            {
                return location;
            }
            set
            {
                location = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
    }

}
