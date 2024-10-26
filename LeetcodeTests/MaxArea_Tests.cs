using NUnit.Framework;

namespace LeetcodeTests
{
    public class MaxArea_Tests
    {
        [Theory]
        [TestCase(new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 }, 49)]
        [TestCase(new int[] { 1, 1 }, 1)]
        [TestCase(new int[] { 1, 7, 2, 5, 4, 7, 3, 6 }, 36)]
        [TestCase(new int[] { 2, 2, 2 }, 4)]
        [TestCase(new int[] { 1, 2, 4, 3, 1 }, 4)]
        public void MaxArea_TestCases(int[] input, int expected)
        {
            Assert.That(LeetcodeLibrary.LeetcodeTasks.MaxArea(input), Is.EqualTo(expected));
        }
    }
}
