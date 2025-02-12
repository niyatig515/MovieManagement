using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAssignment2
{
    internal class IfTwoStringArrayAreEqual
    {
        static void Main(string[]args)
        {
            string[] word1 = new string[] { "ab", "c" };
            string[] word2 = new string[] { "a", "b", "c" };
            if (ArrayStringsAreEqual(word1, word2))
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
        public static bool ArrayStringsAreEqual(string[] word1, string[] word2)
        {
            string s1 = "";
            string s2 = "";
            foreach (string word in word1)
            {
                s1 += word;
            }
            foreach (string word in word2)
            {
                s2 += word;
            }
            return s1.Equals(s2);
        }
    }
}
