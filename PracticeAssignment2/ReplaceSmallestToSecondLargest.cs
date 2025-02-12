using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAssignment2
{
   public class ReplaceSmallestToSecondLargest
    {
        static void Main(string[] args)
        {
            string s = "0332331";
            Console.WriteLine(Replace(s));
        }
        public static string Replace(string s)
        {
            List<string> list = new List<string>();
            for (int i = 0; i < s.Length; i += 2)
                {
                list.Add(s.Substring(i, Math.Min(2, s.Length - i)));
                }
                list.Sort();
                if (list.Count < 2)
                    return s;
                int smallest = int.Parse(list[0]);
                int secondLargest = int.Parse(list[list.Count - 2]);
                int index = s.IndexOf(secondLargest.ToString());
                char[] chars = s.ToCharArray();
                chars[index] = (smallest / 10).ToString()[0];
                chars[index + 1] = (smallest % 10).ToString()[0];

            return new string(chars);
        }
    }
}
