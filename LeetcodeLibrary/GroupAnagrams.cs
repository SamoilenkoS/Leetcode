using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetcodeLibrary
{
    public partial class LeetcodeTasks
    {
        // https://leetcode.com/problems/group-anagrams/
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            var anagramsHelper = new Dictionary<string, List<string>>();
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

            return anagramsHelper.Select(x => x.Value).Cast<IList<string>>().ToList();
        }

        private static string GetSortedString(string str)
        {
            var charArray = str.ToCharArray();
            Array.Sort(charArray);
            return new string(charArray);
        }
    }
}
