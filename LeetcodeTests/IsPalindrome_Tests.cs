using NUnit.Framework;

namespace LeetcodeTests
{
    public class IsPalindrome_Tests
    {
        [Theory]
        [TestCase("Was it a car or a cat I saw?", true)]
        [TestCase("tab a cat", false)]
        [TestCase(" ", true)]
        [TestCase("0P", false)]
        [TestCase(".,", true)]
        public void IsPalindrom_TestCases(string input, bool expected)
        {
            Assert.That(LeetcodeLibrary.LeetcodeTasks.IsPalindrome(input),
                Is.EqualTo(expected));
        }
    }
}
