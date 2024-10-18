using NUnit.Framework;

namespace LeetcodeTests
{
    public class TwoSum_Tests
    {
        [Theory]
        [TestCase(new int[] { 3, 4, 5, 6 }, 7, new int[] { 0, 1 })]
        [TestCase(new int[] { 4, 5, 6 }, 10, new int[] { 0, 2 })]
        [TestCase(new int[] { 5, 5 }, 10, new int[] { 0, 1 })]
        public void TwoSum_TestCases(int[] input, int target, int[] expected)
        {
            var actual = LeetcodeLibrary.LeetcodeTasks.TwoSum(input, target);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
