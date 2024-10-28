using System;
using System.Collections.Generic;

namespace LeetcodeLibrary
{
    public partial class LeetcodeTasks
    {
        //https://leetcode.com/problems/longest-substring-without-repeating-characters
        public static int LongestSubstringWithoutDuplicates(string s)
        {
            int result = 0;
            HashSet<char> set = new HashSet<char>();
            for (int left = 0, right = 0; right < s.Length; ++right)
            {
                while (set.Contains(s[right]))
                {
                    set.Remove(s[left++]);
                }

                set.Add(s[right]);
                result = Math.Max(result, right - left + 1);
            }

            return result;
        }
}
}
