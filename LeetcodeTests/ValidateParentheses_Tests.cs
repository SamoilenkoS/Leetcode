using NUnit.Framework;

namespace LeetcodeTests
{
    public class ValidateParentheses_Tests
    {
        [Theory]
        [TestCase("()", true)]
        [TestCase("()[]{}", true)]
        [TestCase("(]", false)]
        [TestCase("([])", true)]
        [TestCase("([{}])", true)]
        [TestCase("[(])", false)]
        [TestCase("]", false)]
        public void ValidateParentheses_TestCases(string input, bool expected)
        {
            Assert.That(expected, Is.EqualTo(LeetcodeLibrary.LeetcodeTasks.ValidateParentheses(input)));
        }
    }
}
