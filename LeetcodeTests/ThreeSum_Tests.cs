using NUnit.Framework;
using System.Collections;
using System.Linq;

namespace LeetcodeTests
{
    public class ThreeSum_Tests
    {
        public static IEnumerable PositiveTestCases
        {
            get
            {
                yield return new TestCaseData(
                    new int[] { -1, 0, 1, 2, -1, -4 },
                    new int[][] { new int[] { -1, -1, 2 }, new int[] { -1, 0, 1 } });

                yield return new TestCaseData(
                    new int[] { 0, 0, 0 },
                    new int[][] { new int[] { 0, 0, 0 } });

                yield return new TestCaseData(
                    new int[] { 0, 1, 1 },
                    new int[][] { });
            }
        }

        [TestCaseSource(nameof(PositiveTestCases))]
        public void ThreeSum_TestCases(int[] input, int[][] expected)
        {
            var actual = LeetcodeLibrary.LeetcodeTasks.ThreeSum(input);
            Assert.That(actual.Count, Is.EqualTo(expected.Length));

            // Convert each sequence to a sorted version and use a dictionary to count occurrences
            var expectedDict = expected
                .Select(seq => string.Join(",", seq.OrderBy(x => x)))
                .GroupBy(seq => seq)
                .ToDictionary(group => group.Key, group => group.Count());

            var actualDict = actual
                .Select(seq => string.Join(",", seq.OrderBy(x => x)))
                .GroupBy(seq => seq)
                .ToDictionary(group => group.Key, group => group.Count());

            // Check that both dictionaries are equal
            Assert.That(actualDict, Is.EqualTo(expectedDict));
        }
    }
}
