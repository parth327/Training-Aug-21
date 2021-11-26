//Extension Method
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9Pra2
{

    class methods
    {
        public void M1()
        {
            Console.WriteLine("Method Name: M1");
        }

        public void M2()
        {
            Console.WriteLine("Method Name: M2");
        }

        public void M3()
        {
            Console.WriteLine("Method Name: M3");
        }
    }

    static class NewMethodClass 
    {
        public static void M4(this methods m)
        {
            Console.WriteLine("Method Name :M4");
        }

        public static void M5(this methods m, string str)
        {
            Console.WriteLine(str);
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            methods m = new methods();
            m.M1();
            m.M2();
            m.M3();
            m.M4();
            m.M5("Method Name:M5");

            Console.ReadKey();
        }
    }
}
