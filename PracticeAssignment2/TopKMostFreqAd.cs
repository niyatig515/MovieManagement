using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAssignment2
{
    public class TopKMostFreqAd
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string> { "ad1", "ad2", "ad3", "ad1", "ad3", "ad1", "ad3", "ad2" };
            List<string> ans = TopKMostFreqAd1(list, 2);
            foreach (string s in ans)
            {
                Console.Write(s+" ");
            }
        }
        static List<string> TopKMostFreqAd1(List<string>ad, int k)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            foreach (string word in ad)
            {
                if (dict.ContainsKey(word))
                {
                    dict[word]++;
                }
                else
                {
                    dict.Add(word, 1);
                }
            }
            var sd = dict.OrderByDescending(kvp => kvp.Value).ThenByDescending(kvp => kvp.Key).ToList();
            List<string> res = new List<string>();
            for (int i = 0; i < k; i++)
            {
                res.Add(sd[i].Key);
            }
            return res;
        }
    }

}
