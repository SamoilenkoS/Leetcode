using NUnit.Framework;
using System.Collections;
using System.Linq;

namespace LeetcodeTests
{
    public class GroupAnagrams_Tests
    {
        public static IEnumerable Anagrams_TestCases
        {
            get
            {
                yield return new TestCaseData(
                    new string[] { "act", "pots", "tops", "cat", "stop", "hat" },
                    new string[][] {
                        new string[] { "hat" },
                        new string[] { "act", "cat" },
                        new string[] { "stop", "pots", "tops" }
                    });

                yield return new TestCaseData(
                     new string[] { "x" },
                     new string[][] {
                        new string[] { "x" }
                    });

                yield return new TestCaseData(
                     new string[] { "" },
                     new string[][] {
                        new string[] { "" }
                    });
            }
        }

        [TestCaseSource(nameof(Anagrams_TestCases))]
        public void GroupAnagrams_TestCases(string[] input, string[][] expected)
        {
            var actual = LeetcodeLibrary.LeetcodeTasks.GroupAnagrams(input);

            Assert.That(actual.Count, Is.EqualTo(expected.Length));

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
