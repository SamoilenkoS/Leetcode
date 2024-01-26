using LeetcodeLibrary;
using NUnit.Framework;

namespace LeetcodeTests
{
    public class DistributeMoney_Tests
    {
        [Theory]
        [TestCase(20, 3, 1)]
        [TestCase(16, 2, 2)]
        [TestCase(35, 8, 3)]
        [TestCase(1, 10, -1)]
        [TestCase(16, 10, 0)]
        [TestCase(17, 2, 1)]
        [TestCase(24, 2, 1)]
        public void DistributeMoney(int money, int childrenCount, int expectedResult)
        {
            Assert.That(LeetcodeTasks.DistMoney(money, childrenCount), Is.EqualTo(expectedResult));
        }
    }
}
