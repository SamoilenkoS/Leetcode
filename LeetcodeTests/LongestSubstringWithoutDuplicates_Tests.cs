using NUnit.Framework;

namespace LeetcodeTests
{
    public class LongestSubstringWithoutDuplicates_Tests
    {
        [Theory]
        [TestCase("abcabcbb", 3)]
        [TestCase("bbbbb", 1)]
        [TestCase("pwwkew", 3)]
        [TestCase("zxyzxyz", 3)]
        [TestCase("xxxx", 1)]
        [TestCase("dvdf", 3)]
        public void LongestSubstringWithoutDuplicates_TestCases(string input, int expected)
        {
            Assert.That(
                LeetcodeLibrary.LeetcodeTasks.LongestSubstringWithoutDuplicates(input), Is.EqualTo(expected));
        }
    }
}
