using LeetcodeLibrary;
using NUnit.Framework;

namespace LeetcodeTests
{
    public class StrongPasswordChecker_Tests
    {
        [Theory]
        [TestCase("aBcd3r", 0)]
        [TestCase("bxxx", 2)]//2 insert, 1 replace, 2 required
        [TestCase("aaaB1", 1)]//1 insert, 1 replace, 0 required
        [TestCase("aBcd3", 1)]//1 insert, 0 replace, 0 required
        [TestCase("abcde", 2)]//1 insert, 0 replace, 2 required
        [TestCase("aaaaa", 2)]//1 insert, 1 replace, 2 required
        [TestCase("aaabb", 2)]//1 insert, 1 replace, 2 required
        [TestCase("aaa", 3)]//1 replace, 3 required
        [TestCase("aa", 4)]//0 replace, 4 required
        [TestCase("abc", 3)]//add three
        [TestCase("#", 5)]
        [TestCase("aBcd3raBcd3r", 0)]
        [TestCase("baaaa3rbaaaaBcd3r", 2)]//2 replacements, 0 required
        [TestCase("baaaa3raBcd3baaaa", 2)]//2 different replacements, 0 required
        [TestCase("baaaa3rabcd3baaaa", 2)]//2 different replacements, 1 required
        [TestCase("baaaaqrabcdxbaaaa", 2)]//2 different replacements, 2 required
        [TestCase("baaxaqrabcdxBaaqa", 1)]//1 required
        [TestCase("baaxaqrabcdx3aaqa", 1)]//1 different required
        [TestCase("baaxaqrabcdxwaaqa", 2)]//2 different required
        [TestCase("..!..!..!..!..!..", 3)]//3 required
        [TestCase("xxx.xxx.xxx!xxx..", 4)]//4 replacments
        [TestCase("..!..!..!..!..!..!..!", 4)]//0 replacement, 1 remove, 3 required
        [TestCase("xxx..!..xxx!xxx!xxx..!", 4)]//4 replacement, 2 removes, 2 required
        [TestCase("xxx..!..xxx!xxx!xxx..", 4)]//4 replacement, 1 removes, 2 required
        [TestCase("bbaaaaaaaaaaaaaaacccccc", 8)]//7 replacement, 3 removes, 2 required
        [TestCase("aaaabbbbccccddeeddeeddeedd", 8)]//3 replacement, 6 removes, 2 required
        [TestCase("aaxabcbbccccddeeddeeddeedd", 8)]//1 replacement, 6 removes, 2 required
        [TestCase("...!.!.!.!.!.!.!.!.!.!", 5)]//1 replacement, 2 removes,3 required
        [TestCase("...!...!.!.!.!.!.!.!.", 4)]//2 replacement, 1 remove, 3 required
        [TestCase("FFFFFFFFFFFFFFF11111111111111111111AAA", 23)]//12 replacement, 18 remove, 1 required
        [TestCase("A1234567890aaabbbbccccc", 4)]//3 replacement, 3 remove, 0 required
        [TestCase("abAbabababababababaaa", 2)]//1 replacement, 1 remove, 2 required
        [TestCase("aaaaabbbb1234567890ABA", 3)]//2 replacement, 2 remove, 0 required
        [TestCase("1010101010aaaB10101010", 2)]//1 replacement, 2 remove, 0 required
        [TestCase("aaaaaaaAAAAAA6666bbbbaaaaaaABBC", 13)]//10 replacement, 11 remove, 0 required
        public void StrongPasswordChecker(string password, int expectedResult)
        {
            Assert.That(
                LeetcodeTasks.StrongPasswordChecker(password), Is.EqualTo(expectedResult));
        }
    }
}