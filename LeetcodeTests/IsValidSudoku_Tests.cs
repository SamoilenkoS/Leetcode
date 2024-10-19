using NUnit.Framework;
using System.Collections;

namespace LeetcodeTests
{
    public class IsValidSudoku_Tests
    {
        public static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData(
                    new char[][] {
                        new char[]{'8', '3', '.', '.', '7', '.', '.', '.', '.'},
                        new char[]{'6', '.', '.', '1', '9', '5', '.', '.', '.'},
                        new char[]{'.', '9', '8', '.', '.', '.', '.', '6', '.'},
                        new char[]{'8', '.', '.', '.', '6', '.', '.', '.', '3'},
                        new char[]{'4', '.', '.', '8', '.', '3', '.', '.', '1'},
                        new char[]{'7', '.', '.', '.', '2', '.', '.', '.', '6'},
                        new char[]{'.', '6', '.', '.', '.', '.', '2', '8', '.'},
                        new char[]{'.', '.', '.', '4', '1', '9', '.', '.', '5'},
                        new char[]{'.', '.', '.', '.', '8', '.', '.', '7', '9'}
                    }, false);

                yield return new TestCaseData(
                    new char[][]
                    {
                        new char[] { '5', '3', '.', '.', '7', '.', '.', '.', '.' },
                        new char[] { '6', '.', '.', '1', '9', '5', '.', '.', '.' },
                        new char[] { '.', '9', '8', '.', '.', '.', '.', '6', '.' },
                        new char[] { '8', '.', '.', '.', '6', '.', '.', '.', '3' },
                        new char[] { '4', '.', '.', '8', '.', '3', '.', '.', '1' },
                        new char[] { '7', '.', '.', '.', '2', '.', '.', '.', '6' },
                        new char[] { '.', '6', '.', '.', '.', '.', '2', '8', '.' },
                        new char[] { '.', '.', '.', '4', '1', '9', '.', '.', '5' },
                        new char[] { '.', '.', '.', '.', '8', '.', '.', '7', '9' }
                    }, true);
            }
        }

        [TestCaseSource(nameof(TestCases))]
        public void IsValidSudoku_TestCases(char[][] chars, bool expected)
        {
            var actual = LeetcodeLibrary.LeetcodeTasks.IsValidSudoku(chars);

            Assert.IsTrue(expected == actual);
        }
    }
}
