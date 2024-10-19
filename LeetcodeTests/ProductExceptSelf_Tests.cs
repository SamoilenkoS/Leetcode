using NUnit.Framework;

namespace LeetcodeTests
{
    public class ProductExceptSelf_Tests
    {
        [Theory]
        [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { 24, 12, 8, 6 })]
        [TestCase(new int[] { -1, 1, 0, -3, 3 }, new int[] { 0, 0, 9, 0, 0 })]
        public void ProductExceptSelf_TestCases(int[] input, int[] expected)
        {
            var actual = LeetcodeLibrary.LeetcodeTasks.ProductExceptSelf(input);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
