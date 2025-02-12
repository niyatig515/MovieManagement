using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAssignment2
{
    public class MaxValueOfStringInAnArray
    {
        static void Main(string[] args)
        {
            string[] strs = new string[] { "alic3", "bob", "3", "4", "5000" };
            int res = MaximumValue(strs);
            Console.WriteLine(res);
        }
            public static int MaximumValue(string[] strs)
            {
                int length = 0;
                foreach (string s in strs)
                {
                    if (FindLength(s) >= length)
                    {
                        length = FindLength(s);
                    }
                }
                return length;
            }
            public static int FindLength(string s)
            {
                foreach (char c in s)
                {
                    if (Char.IsLetter(c))
                    {
                        return s.Length;
                    }
                }
                return int.Parse(s);
            }
    }
}
