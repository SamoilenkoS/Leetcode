using System;
using System.Linq;

namespace LeetcodeLibrary
{
    public partial class LeetcodeTasks
    {
        //https://leetcode.com/problems/number-of-valid-words-in-a-sentence
        public static int CountValidWords(string sentence)
        {
            return sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries).Count(x => CheckWord(x));
        }

        private static bool CheckWord(string possibleWord)
        {
            bool hypens = false;
            for (int i = 0; i < possibleWord.Length; i++)
            {
                if (char.IsDigit(possibleWord[i]))
                {
                    return false;
                }
                else if (possibleWord[i] == '-')
                {
                    if (hypens)
                    {
                        return false;
                    }
                    else
                    {
                        hypens = true;
                    }
                    if (i == 0 || i == possibleWord.Length - 1 || !char.IsLetter(possibleWord[i + 1]) || !char.IsLetter(possibleWord[i - 1]))
                    {
                        return false;
                    }
                }
                else if ((possibleWord[i] == '.' || possibleWord[i] == ',' || possibleWord[i] == '!') && i != possibleWord.Length - 1)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
