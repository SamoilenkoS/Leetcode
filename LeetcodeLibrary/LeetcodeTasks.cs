using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetcodeLibrary
{
    public partial class LeetcodeTasks
    {
        private const int MinAmount = 6;
        private const int MaxAmount = 20;
        private const int ProblemLettersCountLimit = 3;
        public static int StrongPasswordChecker(string password)
        {
            bool lower = false;
            bool upper = false;
            bool digit = false;
            char? lastChar = null;
            int lastCharCount = 1;
            int problemLettersCount = 0;
            List<int> letters = new List<int>();
            foreach (char c in password)
            {
                if (char.IsLower(c))
                {
                    lower = true;
                }
                else if (char.IsUpper(c))
                {
                    upper = true;
                }
                else if (char.IsDigit(c))
                {
                    digit = true;
                }

                if (lastChar == c)
                {
                    lastCharCount++;
                }
                else
                {
                    lastChar = c;
                    if (lastCharCount >= ProblemLettersCountLimit)
                    {
                        problemLettersCount += lastCharCount / ProblemLettersCountLimit;
                        letters.Add(lastCharCount);
                    }

                    lastCharCount = 1;
                }
            }

            if(lastCharCount >= ProblemLettersCountLimit)
            {
                problemLettersCount += lastCharCount / ProblemLettersCountLimit;
                letters.Add(lastCharCount);
            }

            int lettersRequiredCount = (!lower ? 1 : 0) + (!upper ? 1 : 0) + (!digit ? 1 : 0);
            if (password.Length < MinAmount)
            {
                return Math.Max(
                    Math.Max(problemLettersCount, lettersRequiredCount),
                    MinAmount - password.Length);
            }
            else if (password.Length >= MinAmount &&
                password.Length <= MaxAmount)
            {
                return Math.Max(problemLettersCount, lettersRequiredCount);
            }
            else
            {
                var letterCountToRemove = password.Length - MaxAmount;
                if (problemLettersCount <= lettersRequiredCount)
                {
                    return letterCountToRemove + lettersRequiredCount;
                }
                int originalRemoveCount = letterCountToRemove;
                while (letterCountToRemove != 0)
                {
                    ApplyRemove(letters);
                    --letterCountToRemove;
                }

                problemLettersCount = letters.Select(x => x / ProblemLettersCountLimit).Sum();

                return Math.Max(problemLettersCount, lettersRequiredCount) + originalRemoveCount;
            }
        }

        private static void ApplyRemove(List<int> letters)
        {
            for (int i = 0; i < letters.Count; i++)
            {
                if (letters[i] % ProblemLettersCountLimit == 0)
                {
                    letters[i]--;
                    return;
                }
            }

            int currentDiff = ProblemLettersCountLimit;
            int j = -1;
            for (int i = 0; i < letters.Count; ++i)
            {
                if ((letters[i] / ProblemLettersCountLimit > 0) &&
                    (j == -1 || (letters[i] % ProblemLettersCountLimit < currentDiff)))
                {
                    j = i;
                    currentDiff = letters[i] % ProblemLettersCountLimit;
                }
            }
            if(j != -1)
            {
                letters[j]--;
            }
            else
            {
                letters[0]--;
            }
        }
    }
}
