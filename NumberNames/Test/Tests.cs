using NumberNames;
using NUnit.Framework;

namespace Test
{
    public class Tests
    {
        [TestCase("zero", 0)]
        [TestCase("one", 1)]
        [TestCase("two", 2)]
        [TestCase("nine", 9)]
        [TestCase("ten", 10)]
        [TestCase("nineteen", 19)]
        [TestCase("twenty", 20)]
        [TestCase("eighty nine", 89)]
        [TestCase("ninety nine", 99)]
        [TestCase("one hundred", 100)]
        [TestCase("one hundred and one", 101)]
        [TestCase("one hundred and eighty one", 181)]
        [TestCase("three hundred", 300)]
        [TestCase("three hundred and ten", 310)]
        [TestCase("five hundred and seventy three", 573)]
        [TestCase("one thousand", 1000)]
        [TestCase("one thousand, five hundred and one", 1501)]
        [TestCase("one thousand, six hundred and twenty seven", 1627)]
        [TestCase("nine thousand, nine hundred and ninety nine", 9999)]
        [TestCase("ten thousand", 10000)]
        [TestCase("twelve thousand, six hundred and nine", 12609)]
        [TestCase("eighty seven thousand, three hundred and forty one", 87341)]
        [TestCase("five hundred and twelve thousand, six hundred and seven", 512607)]
        [TestCase("forty three million, one hundred and twelve thousand, six hundred and three", 43112603)]
        public void TestResults(string expectedResult, int numberToTest)
        {
            Assert.AreEqual(expectedResult, NumberName.GetNumberName(numberToTest));
        }
    }
}
