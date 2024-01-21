using LeetcodeLibrary;
using NUnit.Framework;

namespace LeetcodeTests
{
    public class MergeTests
    {
        [Theory]
        [TestCase(new int[] { 1, 2, 3, 0, 0, 0 }, 3, new int[] { 2, 5, 6 }, 3, new int[] { 1, 2, 2, 3, 5, 6 })]
        [TestCase(new int[] { 1 }, 1, new int[] { }, 0, new int[] { 1 })]
        [TestCase(new int[] { 0 }, 0, new int[] { 1 }, 1, new int[] { 1 })]
        [TestCase(new int[] { 4, 5, 6, 0, 0, 0 }, 3, new int[] { 1, 2, 3 }, 3, new int[] { 1, 2, 3, 4, 5, 6 })]
        [TestCase(new int[] { 1, 2, 4, 5, 6, 0 }, 5, new int[] { 3 }, 1, new int[] { 1, 2, 3, 4, 5, 6 })]
        public void Merge(int[] arr1, int m, int[] arr2, int n, int[] expectedResult)
        {
            LeetcodeTasks.Merge(arr1, m, arr2, n);
            Assert.That(arr1, Is.EqualTo(expectedResult));
        }
    }
}
