using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAssignment2
{
    public class LongestRepeatingCharacterReplacement
    {
        static void Main()
        {
            string s = "ABAB";
            int k = 1;
            Console.WriteLine(CharacterReplacement(s, k));
        }

        public static int CharacterReplacement(string s, int k)
        {
            int right = 0;
            int left = 0;
            int maxLength = 0;
            int maxFreq = 0;
            int[] nums = new int[26];
            while (right < s.Length)
            {
                char ch = s[right];
                nums[ch - 'A']++;
                maxFreq = Math.Max(nums[ch - 'A'], maxFreq);
                //Conversion Required
                //Length=right-left+1
                if (right - left + 1 - maxFreq <= k)
                {
                    maxLength = Math.Max(maxLength, right - left + 1);
                }
                else
                {
                    nums[s[left] - 'A']--;
                    left++;
                }
                right++;
            }
            return maxLength;
        }
    }

}
