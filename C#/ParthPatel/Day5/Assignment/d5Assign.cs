using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D5Assign
{
    class Program
    {
        static void Main(string[] args)
        {
            // Rambo Rental Bikes is looking for developing a system to calculate the rentals of the bikes.System should accept the customer details, bike details and calculate the rental charges.
            // DESCRIPTION OF PROJECTS
            //System allows users to add customer details with bike rented.It computes rent for each customer. Systems displays the Bike details with summation of days of hire and rental payment.FUNCTIONALITY AND TASK
            //Define a class called Mobike with the following description: 
            //Instance variables/data members: 
            //BikeNumber – to store the bike’s number
            //PhoneNumber – to store the phone number of the customer
            //Name – to store the name of the customer
            //Days – to store the number of days the bike is taken on rent o charge – to calculate and store the rental charge
            //Member methods:
            //void Input() – to input and store the detail of the customer.
            //void Compute() – to compute the rental charge
            //void display() – to display the details in the following format:
            // Bike No.PhoneNo             No.of days         Charge
            // The rent for a mobike is charged on the following basis:
            //First five days Rs 500 per day
            //Next five days Rs 400 per day
            //Rest of the days Rs 200 per day
            //Use collection Framework to store 10 Customer Details. Implement List operation add, delete, edit and search functionality
            List<Mobike> clients = new List<Mobike>(10);
            clients.Add(new Mobike("Parth", "9223423424", 12));
            clients.Add(new Mobike("Rutvik", "9265914307", 8));
            clients.Add(new Mobike("Raj", "9265914308", 10));
            foreach (var client in clients)
            {
                client.Display();
            }
            Console.WriteLine();
            clients.RemoveAll(client => client.BikeNumber == "1001");
            foreach (var client in clients)
            {
                client.Display();
            }
            foreach (var client in clients)
            {
                if (client.BikeNumber == "1000")
                {
                    client.Days = 5;
                }
            }
            foreach (var client in clients)
            {
                if (client.BikeNumber == "1000")
                {
                    client.Display();
                }
            }
            Console.ReadKey();
        }
    }
    class Mobike
    {
        private static int bikeNumberSeed = 1000;
        public string BikeNumber { get; set; }
        public string PhoneNumber { get; set; }
        public string Name { get; set; }
        public short Days { get; set; }
        public decimal RentalCharge { get; set; }
        public Mobike(string name, string phoneNumber, short days)
        {
            this.input(name, phoneNumber, days);
            this.BikeNumber = bikeNumberSeed.ToString();
            bikeNumberSeed++;
            this.Compute();
        }
        public void input(string name, string phoneNumber, short days)
        {
            this.Name = name;
            this.PhoneNumber = phoneNumber;
            this.Days = days;
        }
        public void Compute()
        {
            int cost = 0;
            for (int i = 0; i < this.Days; i++)
            {
                if (i < 5)
                {
                    cost += 500;
                }
                else if (i < 10)
                {
                    cost += 400;
                }
                else
                {
                    cost += 200;
                }
            }
            this.RentalCharge = cost;
        }
        public void Display()
        {
            Console.WriteLine($"{this.BikeNumber}\t{this.PhoneNumber}\t{this.Days}\t{this.RentalCharge}");
        }
    }
}
