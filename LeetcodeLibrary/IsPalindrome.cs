namespace LeetcodeLibrary
{
    public partial class LeetcodeTasks
    {
        public static bool IsPalindrome(string s)
        {
            for (int i = 0, j = s.Length - 1; i < s.Length && j >= 0; ++i, --j)
            {
                while (i < s.Length && !char.IsLetter(s[i]) && !char.IsDigit(s[i]))
                {
                    ++i;
                }
                while (j > 0 && !char.IsLetter(s[j]) && !char.IsDigit(s[j]))
                {
                    --j;
                }
                if (i < s.Length && j > 0 && char.ToLower(s[i]) != char.ToLower(s[j]))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
