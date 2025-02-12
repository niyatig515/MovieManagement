using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PracticeAssignment2
{
    internal class LongestDuplicateSubstring
    {
        public string LongestDupSubstring(string s)
        {
            int left = 1;
            int right = s.Length;
            string result = "";

            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                string dup = GetDuplicateSubstring(s, mid);
                if (dup != null)
                {
                    result = dup;
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return result;
        }

        private string GetDuplicateSubstring(string s, int cap)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            string result = "";

            for (int i = 0; i <= s.Length - cap; i++) // Fixed loop condition
            {
                string sub = s.Substring(i, cap);
                if (dict.ContainsKey(sub))
                {
                    dict[sub]++;
                }
                else
                {
                    dict[sub] = 1;
                }
            }

            foreach (var sub in dict)
            {
                if (sub.Value > 1)
                {
                    result = sub.Key;
                }
            }

            return result.Length > 0 ? result : null;
        }

        public static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            LongestDuplicateSubstring finder = new LongestDuplicateSubstring();
            string result = finder.LongestDupSubstring(input);

            Console.WriteLine("Longest Duplicate Substring: " + (string.IsNullOrEmpty(result) ? "No duplicates found" : result));
        }
    }
}
