using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PracticeAssignment2
{
    public class MinimumWindowSubstring
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            string s = "ADOBECODEBANC";
            string t = "ABC";
            Console.WriteLine(MinWindow(s, t)); // Expected output: "BANC"
        }

        public static string MinWindow(string s, string t)
        {
            if (s.Length == 0 || t.Length == 0) return "";

            int windowStart = 0, windowEnd = 0, minStart = 0;
            int minLength = int.MaxValue;
            int count = t.Length;
            int[] freq = new int[128];

            // Populate the frequency array with characters from 't'
            foreach (char ch in t) freq[ch]++;

            while (windowEnd < s.Length)
            {
                // Process current character at windowEnd
                if (freq[s[windowEnd]] > 0) count--;
                freq[s[windowEnd]]--;
                windowEnd++;

                // Try to shrink the window if all characters are matched
                while (count == 0)
                {
                    // Update the smallest window found so far
                    if (windowEnd - windowStart < minLength)
                    {
                        minLength = windowEnd - windowStart;
                        minStart = windowStart;
                    }

                    // Shrink the window from the left
                    freq[s[windowStart]]++;
                    if (freq[s[windowStart]] > 0) count++;
                    windowStart++;
                }
            }

            return minLength == int.MaxValue ? "" : s.Substring(minStart, minLength);
        }
    }
}

