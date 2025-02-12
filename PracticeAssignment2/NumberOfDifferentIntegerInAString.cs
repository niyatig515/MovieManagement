using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAssignment2
{
    public class NumberOfDifferentIntegerInAString
    {
        static void Main(string[] args)
        {
            string s = "a123bc34d8ef34";
            Console.WriteLine(NumDifferentIntegers(s));
        }
            public static int NumDifferentIntegers(string word)
            {
                HashSet<string> set = new HashSet<string>();

                for (int i = 0; i < word.Length; i++)
                {
                    StringBuilder sb = new StringBuilder();
                    if (Char.IsDigit(word[i]))
                    {

                        while (i < word.Length && Char.IsDigit(word[i]))
                        {
                            sb.Append(word[i]);
                            i++;
                        }
                        set.Add(sb.ToString().TrimStart('0'));
                    }
                }
                return set.Count;
            }
        }
    }

