using NUnit.Framework;

namespace LeetcodeTests
{
    public class TopKFrequent_Tests
    {
        [Theory]
        [TestCase(new int[] { 1, 2, 2, 3, 3, 3 }, 2, new int[] { 2, 3 })]
        [TestCase(new int[] { 7, 7 }, 1, new int[] { 7 })]
        public void TopKFrequent_TestCases(int[] input, int k, int[] expected)
        {
            var actual = LeetcodeLibrary.LeetcodeTasks.TopKFrequent(input, k);

            CollectionAssert.AreEquivalent(expected, actual);
        }
    }
}
