//2.Store your name in one string and find out how many vowel characters are there in your name.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Ass2
{
    class Program
    {
        public static bool isVowel(char ch)        {
            ch = char.ToUpper(ch);
            return (ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U');
        }
        public static int countVowels(string str)
        {
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (isVowel(str[i]))
                {
                    ++count;
                }
            }
            return count;
        }
        public static void Main(string[] args)
        {
            string str = "Parth Patel";
            Console.WriteLine(countVowels(str));
            Console.ReadKey();
        }
    }
}
