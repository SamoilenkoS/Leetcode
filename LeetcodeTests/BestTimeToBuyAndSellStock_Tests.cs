using NUnit.Framework;

namespace LeetcodeTests
{
    public class BestTimeToBuyAndSellStock_Tests
    {
        [Theory]
        [TestCase(new int[] { 7, 1, 5, 3, 6, 4 }, 5)]
        [TestCase(new int[] { 7, 6, 4, 3, 1 }, 0)]
        [TestCase(new int[] { 10, 1, 5, 6, 7, 1 }, 6)]
        [TestCase(new int[] { 5, 1, 5, 6, 7, 1, 10 }, 9)]
        [TestCase(new int[] { 2, 1, 4 }, 3)]
        public void BestTimeToBuyAndSellStock_TestCases(int[] input, int expected)
        {
            Assert.That(LeetcodeLibrary.LeetcodeTasks.BestTimeToBuyAndSellStock(input), Is.EqualTo(expected));
        }
    }
}
