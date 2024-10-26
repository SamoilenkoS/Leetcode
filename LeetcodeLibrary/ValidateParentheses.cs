using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetcodeLibrary
{
    public partial class LeetcodeTasks
    {
        // https://leetcode.com/problems/valid-parentheses
        public static bool ValidateParentheses(string s)
        {
            string left = "({[";
            Stack<char> items = new Stack<char>();
            foreach (char c in s)
            {
                if (left.Contains(c))
                {
                    items.Push(c);
                }
                else if (!items.Any() || GetPair(items.Peek()) != c)
                {
                    return false;
                }
                else
                {
                    items.Pop();
                }
            }

            return !items.Any();
        }

        private static char GetPair(char a)
        {
            switch (a)
            {
                case '(':
                    return ')';
                case '{':
                    return '}';
                case '[':
                    return ']';
                default:
                    throw new Exception();
            }
        }
    }
}
