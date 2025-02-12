using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordHaveGreatestNumberOfVowelsFromLine
{
    public class WordHaveGreatestNumberOfVowelsFromLine
    {
        public string FindWordWithMostVowelsFromLine(string n)
        {
            string []temp=n.Split(' ');
            string result = "";
            int count = 0;
            foreach (string s in temp)
            {
                if(VowelsCount(s)>count)
                {
                    count = VowelsCount(s);
                    result = s;
                }
            }
            return result;

        }
        public int VowelsCount(string s)
        {
            int count = 0;
            foreach(char ch in s)
            {
                if(ch=='a'|| ch=='e'|| ch=='i'|| ch=='o'||ch=='u')
                    count++;
            }
            return count;
        }
    }
}

