using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Pra
{
    class Button
    {
        public EventHandler<MyCustomAgrs> ClickEvent;
        public void OnClick()
        {
            MyCustomAgrs myargs = new MyCustomAgrs();
            myargs.Name = "Abc";
            ClickEvent.Invoke(this, myargs);
        }
    }
    class MyCustomAgrs : EventArgs
    {
        public string Name { get; set; }
    }
    class Practice
    {
        public delegate void disp();
        public delegate void arithmatic(int a, int b);
        public delegate void anonym(int a);
        public void Display()
        {
            Console.WriteLine("Display method!!");
        }
        public void sum(int a, int b)
        {
            Console.WriteLine($"Sum is : {a + b}");
        }
        public int add(int a, int b)
        {
            return a + b;
        }
        public void mul(int a, int b)
        {
            Console.WriteLine($"Multiplication is : {a * b}");
        }
        static void Main(string[] args)
        {
            Practice p = new Practice();
            disp d1 = new disp(p.Display);
            d1();

            arithmatic adelegate = new arithmatic(p.sum);
            adelegate += p.mul;
            //adelegate(5, 6);
            //adelegate(5, 7);

            Func<int, int, int> addition = p.add;
            int result = addition(5, 10);
            Console.WriteLine(result);

            arithmatic[] delegatearr =
            {
                new arithmatic(p.sum),
                new arithmatic(p.mul)
            };
            for (int i = 0; i < delegatearr.Length; i++)
            {
                delegatearr[i](4, 5);
                delegatearr[i](5, 6);
                delegatearr[i](6, 7);
            }

            anonym obj = delegate (int a)
            {
                Console.WriteLine($"a={a}");
            };
            obj(5);

            anonym lambdafun = (a) => Console.WriteLine($"a={a}");
            lambdafun(10);

            //Console.WriteLine("Press A to invoke an event!");
            //char key = Convert.ToChar(Console.ReadLine());
            //if (key == 'A' || key == 'a')
            //{
            //    //KeyPressed();
            //    Button btn = new Button();
            //    btn.ClickEvent += (x, myargs) =>
            //    {
            //        Console.WriteLine($"You clicked A and Name is {myargs.Name}");
            //    };
            //    btn.OnClick();
            //}
            //else
            //{
            //    Console.WriteLine("You haven't pressed A!!");
            //}
            Console.ReadKey();
        }
    }
}


            