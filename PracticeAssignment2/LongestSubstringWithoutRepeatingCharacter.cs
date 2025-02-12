using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAssignment2
{
    public class LongestSubstringWithoutRepeatingCharacter
    {
        static void Main(string[] args)
        {
            string s = "abcababcab";
            Console.WriteLine(LongestSubstring(s));
        }
        public static int LongestSubstring(string s)
        {
            int windowStart = 0, maxLength = 0;
            int[] freq = new int[26];
            for (int windowEnd = 0; windowEnd < s.Length; windowEnd++)
            {
                char ch = s[windowEnd];

                while (freq[ch - 'a'] > 0)
                {
                    freq[s[windowStart] - 'a']--; 
                    windowStart++; 
                }
                freq[ch - 'a']++;
                int length = windowEnd - windowStart + 1;
                maxLength = Math.Max(maxLength, length);
            }
            return maxLength;
        }
    }
}