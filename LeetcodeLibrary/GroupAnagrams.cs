using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetcodeLibrary
{
    public partial class LeetcodeTasks
    {
        public static List<List<string>> GroupAnagrams(string[] strs)
        {
            Dictionary<string, List<string>> anagramsHelper = new Dictionary<string, List<string>>();
            foreach (string str in strs)
            {
                var sorted = GetSortedString(str);
                if (!anagramsHelper.ContainsKey(sorted))
                {
                    anagramsHelper.Add(sorted, new List<string> { str });
                }
                else
                {
                    anagramsHelper[sorted].Add(str);
                }
            }

            return anagramsHelper.Select(x => x.Value).ToList();
        }

        private static string GetSortedString(string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Sort(charArray);
            return new string(charArray);
        }
    }
}
