using NumberNames;
using NUnit.Framework;

namespace Test
{
    public class Tests
    {
        [TestCase("one", 1)]
        [TestCase("two", 2)]
        [TestCase("nine", 9)]
        [TestCase("ten", 10)]
        [TestCase("nineteen", 19)]
        [TestCase("twenty", 20)]
        [TestCase("eighty nine", 89)]
        [TestCase("one hundred", 100)]
        [TestCase("one hundred and one", 101)]
        [TestCase("five hundred and seventy three", 573)]
        public void TestResults(string expectedResult, int numberToTest)
        {
            Assert.AreEqual(expectedResult, NumberName.GetNumberName(numberToTest));
        }
    }
}
