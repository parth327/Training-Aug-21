using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace D4Prac
//{
//class Program
//{
//    static void Main(string[] args)
//    {
//        //Exception Class
//        int x = 0;
//        try
//        {
//            int y = 100 / x;
//        }
//        catch (ArithmeticException e)
//        {
//            Console.WriteLine($"ArithmeticException Handler: {e}");
//            Console.ReadLine();
//        }
//        catch (Exception e)
//        {
//            Console.WriteLine($"Generic Exception Handler: {e}");
//            Console.ReadLine();
//        }
//    }
//}
//Errors and Exceptions
//public class Person
//{
//    private string _name;

//    public string Name
//    {
//        get { return _name; }
//        set { _name = value; }
//    }

//    public override int GetHashCode()
//    {
//        return this.Name.GetHashCode();
//    }

//    public override bool Equals(object obj)
//    {
//        // This implementation handles a null obj argument.
//        Person p = obj as Person;
//        if (p == null)
//            return false;
//        else
//            return this.Name.Equals(p.Name);
//    }
//}

//public class Example
//{
//    public static void Main()
//    {
//        Person p1 = new Person();
//        p1.Name = "John";
//        Person p2 = null;

//        Console.WriteLine("p1 = p2: {0}", p1.Equals(p2));
//        Console.ReadLine();
//    }
//}
//Strings and Indexes

string s1 = "This string consists of a single short sentence.";
int nWords = 0;
s1 = s1.Trim();
for (int ctr = 0; ctr < s1.Length; ctr++)
{
    if (Char.IsPunctuation(s1[ctr]) | Char.IsWhiteSpace(s1[ctr]))
        nWords++;
}
Console.WriteLine("The sentence\n   {0}\nhas {1} words.",s1, nWords);
Console.ReadLine();
//}
