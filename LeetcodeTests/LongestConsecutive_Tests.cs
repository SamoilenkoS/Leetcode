using NUnit.Framework;

namespace LeetcodeTests
{
    public class LongestConsecutive_Tests
    {
        [Theory]
        [TestCase(new int[] { 100, 4, 200, 1, 3, 2 }, 4)]
        [TestCase(new int[] { 0, 3, 7, 2, 5, 8, 4, 6, 0, 1 }, 9)]
        public void LongestConsecutive(int[] input, int expected)
        {
            var actual = LeetcodeLibrary.LeetcodeTasks.LongestConsecutive(input);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
