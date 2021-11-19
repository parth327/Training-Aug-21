using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d5Prac
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Create a list which will store 5 student names and then display it search it index number
            //var names = new List<string>();
            //names.Add("Sonoo Jaiswal");
            //names.Add("Ankit");
            //names.Add("Peter");
            //names.Add("Irfan");
            //foreach (var name in names)
            //{
            //    Console.WriteLine(name);
            //    Console.ReadLine();
            //}
            //2.Create a stack which will store Age of person and display it last in first out order.
            //Stack st = new Stack();
            //st.Push(18);
            //st.Push(21);
            //st.Push(28);
            //st.Push(35);
            //Console.WriteLine("Click to Display Age Stack: ");
            //Console.ReadLine();
            //foreach (int c in st) 
            //{
            //    Console.WriteLine(c + " ");
            //    Console.ReadLine();

            //}
            //Console.WriteLine();
            //st.Push(45);
            //st.Push(20);
            //Console.WriteLine("New Entreis Added", st.Peek());
            //Console.WriteLine("Now Age Stack: ");
            //Console.ReadLine();
            //foreach (int c in st)
            //{
            //    Console.WriteLine(c + " ");
            //    Console.ReadLine();
            //}  
            //Console.WriteLine();
            //Console.WriteLine("Remove age First in last out Order : ");
            //st.Pop();
            //Console.WriteLine("Current Age Stack: ");
            //foreach (int c in st)
            //{
            //    Console.WriteLine(c + " ");
            //    Console.ReadLine();
            //}
            //3.Store a product information in map object.Key will be a product item and value will be the price of that product. Search the product by product name.

            Dictionary<string, int> products = new Dictionary<string, int>();

            products.Add("Laptop", 28000);
            products.Add("Desktop", 40000);
            products.Add("Tablet", 5000);

            string searchKey;
            Console.WriteLine("Enter Product Name(Laptop,Desktop,Tablet)");
            searchKey = Console.ReadLine();

            foreach (var product in products)
            {
                if (product.Key == searchKey)
                {
                    Console.WriteLine($"product name is {product.Key} and cost is {product.Value}");
                }
            }
            Console.ReadLine();
        }
    }
}   

