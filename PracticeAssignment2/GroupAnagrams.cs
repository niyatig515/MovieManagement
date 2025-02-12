using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAssignment2
{
    public class GroupAnagrams
    {
        public static void Main(string[] args)
        {
            string[] words = { "eat", "tea", "tan", "ate", "nat", "bat" };

            IList<IList<string>> result = GroupAnagram(words);
            foreach (var group in result)
            {
                Console.WriteLine($"[{string.Join(", ", group)}]");
            }
        }
            public static IList<IList<string>> GroupAnagram(string[] strs)
        {
            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();
            foreach (string s in strs)
            {
                char[] arr = s.ToCharArray();
                Array.Sort(arr);
                string str = new string(arr);
                if (dict.ContainsKey(str))
                {
                    dict[str].Add(s);
                }
                else
                    dict.Add(str, new List<string> { s });
            }
            return dict.Values.ToList<IList<string>>();
        }
    }
}
