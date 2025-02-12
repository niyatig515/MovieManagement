using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;

namespace PracticeAssignment2
{
    internal class SwapForLongestRepeatingCharacter
    {
        public int MaxRepOpt1(string word)
        {
            Dictionary<char, List<int>> indices = new Dictionary<char, List<int>>();

            // Store indices of each character in the dictionary
            for (int i = 0; i < word.Length; i++)
            {
                if (indices.ContainsKey(word[i]))
                {
                    indices[word[i]].Add(i);
                }
                else
                {
                    indices[word[i]] = new List<int>() { i };
                }
            }

            int result = 0;

            // Process each character and determine the max length of repeating substring
            foreach (var ch in indices)
            {
                var indexes = ch.Value;
                int swapCount = 0;
                int conseCount = 1;
                int max = 0;

                for (int i = 0; i < indexes.Count - 1; i++)
                {
                    if (indexes[i + 1] == indexes[i] + 1)
                    {
                        conseCount++;
                    }
                    else
                    {
                        swapCount = (indexes[i + 1] == indexes[i] + 2 ? conseCount : 0);
                        conseCount = 1;
                    }
                    max = Math.Max(max, swapCount + conseCount);
                }

                result = Math.Max(result, max + (max < indexes.Count ? 1 : 0));
            }

            return result;
        }

        public static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            SwapForLongestRepeatingCharacter obj = new SwapForLongestRepeatingCharacter();
            int result = obj.MaxRepOpt1(input);

            Console.WriteLine("Maximum length of repeated character substring after swap: " + result);
        }
    }
}
