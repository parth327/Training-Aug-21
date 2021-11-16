using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d7Prac
{
    class Program
    {
        static void Main(string[] args)
        {
            //Example 1
            //var primes = new List<int>{ 1,2,3,5,7,11,13,17,19,23 };
            //var query = from val in primes
            //            where val < 13
            //            select val;
            //foreach (var val in query)
            //    Console.WriteLine(val);
            //var methodquery = primes.Where(x => x < 13);
            //    foreach (var val in methodquery)
            //    Console.WriteLine(val);
            //Console.ReadLine();
            //Example 2
            //var listOne = Enumerable.Empty<int>();
            //var listTwo = Enumerable.Range(1,20);
            //bool listOneEmpty = listOne.Any();
            //bool listTwoEmpty = listTwo.Any();
            //Console.WriteLine("list one has members?" + listOneEmpty + "list two has members?" + listTwoEmpty);
            //Console.WriteLine("listTwo has 12?" + listTwo.Contains(12) + "listTwo has 30?" + listTwo.Contains(30));
            //Console.ReadLine();
            //Example 3
            //var bigList = Enumerable.Range(1, 20);
            //var littleList = bigList.Take(5).Select(x => x * 10);
            //foreach (var i in littleList)
            //    Console.WriteLine(i);
            //Console.ReadLine();
            //Example 4
            string[] postalCodes = {"AL","AK","AZ","AR","CA","CO","CT","DE","FL" };
            string[] states = {"Alabama","Alaska","Arizona","Arkansas","California","Colorodo","Connecticut","Deleware","Florida" };
            var statesWithCodes = postalCodes.Zip(states, (code, state) => code + ": " + state);
            foreach (var stateWithCode in statesWithCodes)
            {
                Console.WriteLine(stateWithCode);
                Console.ReadLine();
            }

        }
    }
}
