using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//public delegate int AreaDelegate(int l, int b);
namespace d6Assign
{
    //class Program
    //{
    //    static void Main(string[] Args)
    //    {
    //        //Assignment
    //        //1.Compute area of rectangle using func delegate
    //        AreaDelegate x = new AreaDelegate(AreaRec);
    //        var result = x.Invoke(10, 20);
    //        Console.WriteLine("Area Of Rectangle :" + result);
    //        Console.ReadLine();
    //        Delegatedemo demo = new Delegatedemo();
    //        AreaDelegate y = new AreaDelegate(demo.MulNum);
    //        var resultdelegatedemo = y.Invoke(30, 20);
    //        Console.WriteLine("Area of Rectangle :" + resultdelegatedemo);
    //        Console.ReadLine();
    //    }
    //    public static int AreaRec(int l, int b) {
    //        return l * b;
    //    }
    //}
    //class Delegatedemo
    //{
    //    public int MulNum(int l, int b)
    //    {
    //        return l * b;
    //    }
    //}
    //2. Compute add of two number using lambda expression
    class Program
    {
        static void Main(string[] args)
        {
            Func<double, double, double> area = (double height, double widtht) => (height * widtht);
            Console.WriteLine(area(6.3, 5.2));
            Func<int, int, int> sum = (int num1, int num2) => (num1 + num2);
            Console.WriteLine(sum(2, 3));
            Console.ReadKey();
        }
    }
}